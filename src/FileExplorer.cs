using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

// singleton implementation
public class FileExplorer {

    private static FileExplorer instance = new FileExplorer();
    private static readonly object lock_object = new object();
    private Dictionary<string, long> selected_files = new Dictionary<string, long>();

    private FileExplorer() {
        this.selected_files = new Dictionary<string, long>();
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

            foreach(string file in file_explorer.FileNames)
            {
                FileInfo fileInfo = new FileInfo(file);

                if (!selected_files.ContainsKey(fileInfo.Name)) { 
                    this.selected_files.Add(Path.GetFileName(file), fileInfo.Length); 
                }

            }

        }

    }
        
    public Dictionary<string, long> get_selected_files() {

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

    public void refresh(CheckedListBox box) { 
        lock(lock_object) {
            // refresh selected
            box.Items.Clear();

            foreach (var item in FileExplorer.Instance.get_selected_files())
            {
                Debug.WriteLine(Path.GetFileName(item.Key));
                box.Items.Add(item.Key, false);
            }
        }
    }
}