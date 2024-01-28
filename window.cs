using System.Diagnostics;

namespace danverter {

    public partial class Danverter : Form
    {

        public Danverter()
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Size = new System.Drawing.Size(600, 600);

            string[] quality_options = new string[] { "44100 Hz", "48000 Hz" };

            combobox_quality.Items.AddRange(quality_options);
            combobox_quality.SelectedIndex = 1;
        }

        // some organization on this, but this might be really messy anyways

        private void mp3_button_browse_files_click(object sender, EventArgs e)
        {
            MP3FileExplorer.Instance.open_file_explorer();
            MP3FileExplorer.Instance.refresh(display_selected_files, label_number_files);
        }

        private void mp3_button_delete_selected_files_click(object sender, EventArgs e)
        {
            MP3FileExplorer.Instance.delete_selected_files(display_selected_files);
            MP3FileExplorer.Instance.refresh(display_selected_files, label_number_files);
        }

        private void mp3_button_clear_click(object sender, EventArgs e)
        {
            MP3FileExplorer.Instance.clear();
            MP3FileExplorer.Instance.refresh(display_selected_files, label_number_files);
        }

        private void mp3_button_output_directory(object sender, EventArgs e)
        {
            MP3FileExplorer.Instance.set_output_directory(textbox_output_directory);
        }

        private void mp3_button_start(object sender, EventArgs e)
        {
            MP3FileExplorer.Instance.start_mp3_to_wav(combobox_quality, progress_mp3);
        }
    }
}
