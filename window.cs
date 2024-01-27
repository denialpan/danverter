using System.Diagnostics;

namespace danverter {


    public partial class danverter : Form
    {
        private string[] selected_files;
        
        public danverter() {
            InitializeComponent();
        }

        private void button_browse_files_click(object sender, EventArgs e) {

            Files.Instance.open_file_explorer();

            foreach (string file in Files.Instance.get_selected_files()) {
                Debug.WriteLine(Path.GetFileName(file));
            }
        }
    }
}
