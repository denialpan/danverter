using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

// singleton implementation
public class FileExplorer {

    private static FileExplorer instance;
    private static readonly object lock_object = new object();
    private List<string> selected_files = new List<string>();

    private FileExplorer() {
        this.selected_files = new List<string>();
    }

    public static FileExplorer Instance {

        get { 
            if (instance == null) { 
                lock(lock_object) {
                    if (instance == null) {
                        instance = new FileExplorer();
                    }
                }
            }
            return instance;
        }

    }

    public void open_file_explorer () { 
        
        OpenFileDialog file_explorer = new OpenFileDialog();
        file_explorer.Multiselect = true;

        DialogResult valid_files = file_explorer.ShowDialog();

        if (valid_files == DialogResult.OK) {

            this.selected_files.AddRange(file_explorer.FileNames); 

        }

    }

    public List<string> get_selected_files() {

        lock (lock_object) { 
            return selected_files;
        }

    }

    public void clear_selected_files() { 
        lock(lock_object) { 
            this.selected_files.Clear();
        }
    }
}