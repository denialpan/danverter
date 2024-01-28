using System.Diagnostics;

// singleton implementation
public class ShadowplayFileExplorer { 

    private static ShadowplayFileExplorer instance = new ShadowplayFileExplorer();
    private static readonly object lock_object = new object();

    private string selected_file = "";
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

    public void start_mp4_conversion() {
        MessageBox.Show(output_type + " " + selected_file);
    }

}