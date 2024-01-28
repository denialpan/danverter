using System.Diagnostics;

// singleton implementation
public class MP3FileExplorer {

    private static MP3FileExplorer instance = new MP3FileExplorer();
    private static readonly object lock_object = new object();

    // file name, file name with directory
    private Dictionary<string, string> selected_files = new Dictionary<string, string>();
    
    private string output_directory = "";

    private MP3FileExplorer() {
        this.selected_files = new Dictionary<string, string>();
    }

    public static MP3FileExplorer Instance {

        get { 
            if (instance == null) { 
                lock(lock_object) {
                    if (instance == null) {
                        instance = new MP3FileExplorer();
                    }
                }
            }
            return instance;
        }

    }

    public void open_file_explorer () { 
        
        OpenFileDialog file_explorer = new OpenFileDialog();
        file_explorer.Multiselect = true;
        file_explorer.Filter = "mp3 files (*.mp3)|*.mp3";

        DialogResult valid_files = file_explorer.ShowDialog();

        if (valid_files == DialogResult.OK) {

            foreach(string file in file_explorer.FileNames) {

                if (!selected_files.ContainsKey(Path.GetFileName(file))) {
                    this.selected_files.Add(Path.GetFileName(file), file);
                }

            }

        }   

    }
        
    public Dictionary<string, string> get_selected_files() {

        lock (lock_object) { 
            return selected_files;
        }

    }

    public void delete_selected_files(CheckedListBox box) { 
        lock (lock_object)
        {
            foreach (string item in box.CheckedItems) {
                this.selected_files.Remove(item);
            }
           
        }
    }

    public void clear() { 
        lock(lock_object) { 
            this.selected_files.Clear();
        }
    }

    public void refresh(CheckedListBox box, Label label) { 
        lock(lock_object) {
            // refresh selected
            box.Items.Clear();

            foreach (var item in MP3FileExplorer.Instance.get_selected_files())
            {
                Debug.WriteLine(Path.GetFileName(item.Key));
                box.Items.Add(Path.GetFileName(item.Key), false);
            }
            label.Text = selected_files.Count.ToString() + " files";
        }
    }

    public void set_output_directory(TextBox textbox_output) {

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

    public void start_mp3_to_wav(ComboBox ar_quality, ProgressBar progress) {

        Debug.WriteLine(this.output_directory);
        
        if (this.output_directory == "") {
            MessageBox.Show("No output directory specified");
        } else {

            int amount_of_commands = this.selected_files.Count;
            progress.Maximum = amount_of_commands;
            progress.Value = 0;

            // safely dispose of process once all commands have been completed
            using (Process mp3_process = new Process
            {

                StartInfo = new ProcessStartInfo
                {

                    FileName = "ffmpeg.exe",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    UseShellExecute = false,

                }

            }) {

                foreach (KeyValuePair<string, string> pair in selected_files) {

                    int hz = 0;
                    if (ar_quality.SelectedItem != null && ar_quality.SelectedItem.ToString() == "48000 Hz") {
                        hz = 48000;
                    } else {
                        hz = 44100;
                    }

                    Debug.WriteLine(pair.Value);

                    string ffmpeg_command = $"-y -i \"{pair.Value}\" -ar {hz} -f wav \"{output_directory}\\{Path.GetFileNameWithoutExtension(pair.Key)}.wav\"";
                    Debug.WriteLine(ffmpeg_command);
                    mp3_process.StartInfo.Arguments = ffmpeg_command;

                    // Start the process
                    mp3_process.Start();

                    // Capture the output
                    string output = mp3_process.StandardOutput.ReadToEnd();
                    string error = mp3_process.StandardError.ReadToEnd();

                    // Wait for the process to exit
                    mp3_process.WaitForExit();

                    // Print the output (you might want to handle it as needed)
                    Debug.WriteLine($"Output: {output}");
                    Debug.WriteLine($"Error: {error}");

                    progress.Value++;

                };

                Debug.WriteLine("All FFmpeg commands executed.");
                Debug.WriteLine("amount of commands executed: " + selected_files.Count);

                progress.Value = amount_of_commands;
                MessageBox.Show("All conversions completed.");


            }
        }

    }
}