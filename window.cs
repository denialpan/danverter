using System.Diagnostics;

namespace danverter {

    public partial class Danverter : Form
    {

        public Danverter()
        {
            InitializeComponent();
            this.MinimumSize = new Size(600, 600);
            this.Size = new Size(600, 600);

            string[] mp3_to_wav_quality = new string[] { "44100 Hz", "48000 Hz" };
            string[] audio_quality = new string[] { "320 kbps (Insane)", "256 kbps (Extreme)", "192 kbps (Standard) (default)", "128 kbps (Medium)" };


            combobox_quality.Items.AddRange(mp3_to_wav_quality);
            combobox_quality.SelectedIndex = 1;

            combobox_audio_quality.Items.AddRange(audio_quality);
            combobox_audio_quality.SelectedIndex = 2;

            checkbox_automatic_quality.Checked = true;

            radiobutton_mp4.Checked = true;
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
            MP3FileExplorer.Instance.set_output_directory(textbox_output_directory_mp3);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_automatic_quality_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_automatic_quality.Checked)
            {
                groupbox_advanced_options.Enabled = false;
            }
            else
            {
                groupbox_advanced_options.Enabled = true;
            }
        }

        private void textbox_advanced_bitrate(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button_output_directory_shadowplay_click(object sender, EventArgs e)
        {
            ShadowplayFileExplorer.Instance.set_output_directory(textbox_output_directory_shadowplay);
        }
    }
}
