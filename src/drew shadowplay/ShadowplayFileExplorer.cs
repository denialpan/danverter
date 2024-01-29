using System.Diagnostics;
using System.Text.RegularExpressions;

// singleton implementation
public class ShadowplayFileExplorer { 

    private static ShadowplayFileExplorer instance = new ShadowplayFileExplorer();
    private static readonly object lock_object = new object();

    private string selected_file = "";
    private string output_directory = "";
    private string output_type = "";

    private ShadowplayFileExplorer() {
        this.selected_file = "";
    }

    public static ShadowplayFileExplorer Instance { 
    
        get {
            if (instance == null) {
                lock (lock_object) {
                    if (instance == null) {
                        instance = new ShadowplayFileExplorer();
                    }
                }
            }
            return instance;
        }

    }

    public void open_file_explorer() { 
        OpenFileDialog file_explorer = new OpenFileDialog();
        file_explorer.Multiselect = false;
        file_explorer.Filter = "mp4 files (*.mp4)|*.mp4";

        DialogResult valid_files = file_explorer.ShowDialog();

        if (valid_files == DialogResult.OK) {
            this.selected_file = file_explorer.FileName;
        }
    }

    public string get_file() {
        return this.selected_file;
    }

    public void set_output_type(string s) {
        this.output_type = s;
    }

    public void set_output_directory(TextBox textbox_output)
    {

        using (FolderBrowserDialog file_explorer = new FolderBrowserDialog())
        {

            // Show the dialog and get the result   
            DialogResult result = file_explorer.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(file_explorer.SelectedPath))
            {
                this.output_directory = file_explorer.SelectedPath;
                textbox_output.Text = file_explorer.SelectedPath;

            }

        }

    }

    public void start_mp4_to_mp3_conversion(string time_start, string time_end, int audio_quality, string filename) {

        if (this.output_directory == "" || this.selected_file == "") {
            MessageBox.Show("No input file or no output directory specified");
        } else {

            string ffmpeg_command;
            // construct ffmpeg command

            string aq;
            string fn;
            switch (audio_quality) {
                case 0: 
                    aq = "320k";
                    break;
                case 1:
                    aq = "256k";
                    break;
                case 2:
                    aq = "192k";
                    break;
                case 3:
                    aq = "128k";
                    break;
                default:
                    aq = "192k";
                    break;
            }

            if (filename == "") {
                fn = Path.GetFileNameWithoutExtension(selected_file);
            } else {
                fn = filename;
            }

            ffmpeg_command = $"-y -i \"{selected_file}\" -vn -acodec libmp3lame -b:a {aq} -map_metadata -1 -ss {time_start} -to {time_end} -f mp3 \"{output_directory}\\{fn}.mp3\"";

            using (Process shadowplay_process = new Process
            {

                StartInfo = new ProcessStartInfo
                {

                    FileName = "ffmpeg.exe",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = false,
                    UseShellExecute = false,
                    Arguments = ffmpeg_command,

                }

            }) {

                // Start the process
                shadowplay_process.Start();

                // Capture the output
                string output = shadowplay_process.StandardOutput.ReadToEnd();
                string error = shadowplay_process.StandardError.ReadToEnd();

                // Wait for the process to exit
                shadowplay_process.WaitForExit();

                // Print the output (you might want to handle it as needed)
                Debug.WriteLine($"Output: {output}");
                Debug.WriteLine($"Error: {error}");

            }

            MessageBox.Show("Finished");
        }
    }

    public void start_mp4_to_trimmed_mp4_conversion(string time_start, string time_end, bool automatic, int bitrate, string filename)
    {
        if (this.output_directory == "" || this.selected_file == "") {
            MessageBox.Show("No input file or no output directory specified");
        } else {

            string ffmpeg_command;
            string fn;

            if (filename == "") {
                fn = Path.GetFileNameWithoutExtension(selected_file);
            } else {
                fn = filename;
            }

            if (automatic)
            {

                ffmpeg_command = $"-y -i \"{selected_file}\" -c:v libx264 -c:a copy -b:v 4000000 -hide_banner -v quiet -stats -map_metadata -1 -ss {time_start} -to {time_end} -f mp4 \"{output_directory}\\{fn}.mp4\"";
            }
            else {
                ffmpeg_command = $"-y -i \"{selected_file}\" -c:v libx264 -c:a copy -b:v {bitrate} -hide_banner -v quiet -stats -map_metadata -1 -ss {time_start} -to {time_end} -f mp4 \"{output_directory}\\{fn}.mp4\"";
                Debug.WriteLine(ffmpeg_command);
            }

            using (Process shadowplay_process = new Process
            {

                StartInfo = new ProcessStartInfo
                {
                    FileName = "ffmpeg.exe",
                    RedirectStandardOutput = false,
                    RedirectStandardError = false,
                    CreateNoWindow = false,
                    UseShellExecute = false,
                    Arguments = ffmpeg_command,

                    // future use
                    //FileName = "ffmpeg.exe",
                    //RedirectStandardOutput = false,
                    //RedirectStandardError = true,
                    //CreateNoWindow = false,
                    //UseShellExecute = false,
                    //Arguments = ffmpeg_command,   

                }

            })
            {

                // Start the process
                shadowplay_process.Start();
                //shadowplay_process.BeginErrorReadLine();

                shadowplay_process.ErrorDataReceived += parse_output;

                shadowplay_process.WaitForExit();
            }

            MessageBox.Show("Finished (actual progress bar will be implemented soon)");

        }
    }

    private void parse_output(object sender, DataReceivedEventArgs e) {
        // Parse the output to extract progress information
        if (!string.IsNullOrEmpty(e.Data) && e.Data.Contains("frame="))
        {
            string[] lines = e.Data.Split('\n');

            foreach (string notparsed in lines)
            {
                if (notparsed.Contains("frame="))
                {
                    String line = notparsed.Replace(" ", "");
                    // Use regular expression to match the frame number
                    string pattern = @"frame=(\d+)";
                    Match match = Regex.Match(line, pattern);

                    if (match.Success)
                    {
                        // Extract the frame number
                        string frameNumberString = match.Groups[1].Value;

                        if (int.TryParse(frameNumberString, out int frameNumber))
                        {
                            // Use the frameNumber as needed (print, log, etc.)
                            Debug.WriteLine(frameNumber);
                        }
                    }
                }
            }
        }

    }
}