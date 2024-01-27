using System.Diagnostics;

namespace danverter {

    public partial class Danverter : Form
    {

        public Danverter()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Size = new System.Drawing.Size(600, 500);
        }

        private void button_browse_files_click(object sender, EventArgs e)
        {
            FileExplorer.Instance.open_file_explorer();
            FileExplorer.Instance.refresh(display_selected_files);
        }

        private void button_delete_selected_files_click(object sender, EventArgs e)
        {
            FileExplorer.Instance.delete_selected_files(display_selected_files);
            FileExplorer.Instance.refresh(display_selected_files);
        }

        private void button_clear_click(object sender, EventArgs e)
        {
            FileExplorer.Instance.clear();
            FileExplorer.Instance.refresh(display_selected_files);
        }
    }
}
