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
            MP3FileExplorer.Instance.refresh(display_selected_mp3_files, label_number_files);
        }

        private void mp3_button_delete_selected_files_click(object sender, EventArgs e)
        {
            MP3FileExplorer.Instance.delete_selected_files(display_selected_mp3_files);
            MP3FileExplorer.Instance.refresh(display_selected_mp3_files, label_number_files);
        }

        private void mp3_button_clear_click(object sender, EventArgs e)
        {
            MP3FileExplorer.Instance.clear();
            MP3FileExplorer.Instance.refresh(display_selected_mp3_files, label_number_files);
        }

        private void mp3_button_output_directory(object sender, EventArgs e)
        {
            MP3FileExplorer.Instance.set_output_directory(textbox_output_directory);
        }

        private void mp3_button_start(object sender, EventArgs e)
        {
            MP3FileExplorer.Instance.start_mp3_to_wav(combobox_quality, progress_mp3);
        }

        private void button_select_file_shadowplay_click(object sender, EventArgs e)
        {
            ShadowplayFileExplorer.Instance.open_file_explorer();
            textbox_file_shadowplay.Text = ShadowplayFileExplorer.Instance.get_file();
        }

        private void button_shadowplay_start_click(object sender, EventArgs e)
        {
            ShadowplayFileExplorer.Instance.start_mp4_conversion();
        }

        private void radiobutton_mp3_CheckedChanged(object sender, EventArgs e)
        {
            ShadowplayFileExplorer.Instance.set_output_type("mp3");
            groupbox_mp4_options.Enabled = false;
            groupbox_mp3_options.Enabled = true;
        }

        private void radiobutton_mp4_CheckedChanged(object sender, EventArgs e)
        {
            ShadowplayFileExplorer.Instance.set_output_type("mp4");
            groupbox_mp3_options.Enabled = false;
            groupbox_mp4_options.Enabled = true;
        }

    }
}
