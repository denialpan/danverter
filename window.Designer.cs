namespace danverter
{
    partial class Danverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_browse_mp3_files = new Button();
            groupbox_select_files = new GroupBox();
            button_clear = new Button();
            button_delete_selected_files = new Button();
            display_selected_files = new CheckedListBox();
            label_description = new Label();
            tab_operation = new TabControl();
            tab_mp3_to_wav = new TabPage();
            groupbox_output = new GroupBox();
            textBox1 = new TextBox();
            button_output_mp3_wav = new Button();
            tab_drew_shadowplay = new TabPage();
            groupbox_select_files.SuspendLayout();
            tab_operation.SuspendLayout();
            tab_mp3_to_wav.SuspendLayout();
            groupbox_output.SuspendLayout();
            SuspendLayout();
            // 
            // button_browse_mp3_files
            // 
            button_browse_mp3_files.Location = new Point(6, 22);
            button_browse_mp3_files.Name = "button_browse_mp3_files";
            button_browse_mp3_files.Size = new Size(75, 23);
            button_browse_mp3_files.TabIndex = 0;
            button_browse_mp3_files.Text = "Browse ...";
            button_browse_mp3_files.UseVisualStyleBackColor = true;
            button_browse_mp3_files.Click += mp3_button_browse_files_click;
            // 
            // groupbox_select_files
            // 
            groupbox_select_files.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupbox_select_files.Controls.Add(button_clear);
            groupbox_select_files.Controls.Add(button_delete_selected_files);
            groupbox_select_files.Controls.Add(display_selected_files);
            groupbox_select_files.Controls.Add(label_description);
            groupbox_select_files.Controls.Add(button_browse_mp3_files);
            groupbox_select_files.Location = new Point(6, 6);
            groupbox_select_files.Name = "groupbox_select_files";
            groupbox_select_files.Size = new Size(553, 253);
            groupbox_select_files.TabIndex = 1;
            groupbox_select_files.TabStop = false;
            groupbox_select_files.Text = "Select Files";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_clear.Location = new Point(472, 223);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(75, 23);
            button_clear.TabIndex = 5;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += mp3_button_clear_click;
            // 
            // button_delete_selected_files
            // 
            button_delete_selected_files.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_delete_selected_files.Location = new Point(348, 223);
            button_delete_selected_files.Name = "button_delete_selected_files";
            button_delete_selected_files.Size = new Size(118, 23);
            button_delete_selected_files.TabIndex = 4;
            button_delete_selected_files.Text = "Delete selected";
            button_delete_selected_files.UseVisualStyleBackColor = true;
            button_delete_selected_files.Click += mp3_button_delete_selected_files_click;
            // 
            // display_selected_files
            // 
            display_selected_files.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            display_selected_files.CheckOnClick = true;
            display_selected_files.FormattingEnabled = true;
            display_selected_files.Location = new Point(6, 51);
            display_selected_files.Name = "display_selected_files";
            display_selected_files.Size = new Size(541, 166);
            display_selected_files.TabIndex = 3;
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new Point(87, 26);
            label_description.Name = "label_description";
            label_description.Size = new Size(156, 15);
            label_description.TabIndex = 2;
            label_description.Text = "You can select multiple files!";
            // 
            // tab_operation
            // 
            tab_operation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tab_operation.Controls.Add(tab_mp3_to_wav);
            tab_operation.Controls.Add(tab_drew_shadowplay);
            tab_operation.Location = new Point(12, 12);
            tab_operation.Name = "tab_operation";
            tab_operation.SelectedIndex = 0;
            tab_operation.Size = new Size(573, 487);
            tab_operation.TabIndex = 2;
            // 
            // tab_mp3_to_wav
            // 
            tab_mp3_to_wav.Controls.Add(groupbox_output);
            tab_mp3_to_wav.Controls.Add(groupbox_select_files);
            tab_mp3_to_wav.Location = new Point(4, 24);
            tab_mp3_to_wav.Name = "tab_mp3_to_wav";
            tab_mp3_to_wav.Padding = new Padding(3);
            tab_mp3_to_wav.Size = new Size(565, 459);
            tab_mp3_to_wav.TabIndex = 0;
            tab_mp3_to_wav.Text = "mp3 to wav";
            tab_mp3_to_wav.UseVisualStyleBackColor = true;
            // 
            // groupbox_output
            // 
            groupbox_output.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupbox_output.Controls.Add(textBox1);
            groupbox_output.Controls.Add(button_output_mp3_wav);
            groupbox_output.Location = new Point(6, 265);
            groupbox_output.Name = "groupbox_output";
            groupbox_output.Size = new Size(553, 188);
            groupbox_output.TabIndex = 2;
            groupbox_output.TabStop = false;
            groupbox_output.Text = "Output";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(87, 22);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(460, 23);
            textBox1.TabIndex = 1;
            // 
            // button_output_mp3_wav
            // 
            button_output_mp3_wav.Location = new Point(6, 21);
            button_output_mp3_wav.Name = "button_output_mp3_wav";
            button_output_mp3_wav.Size = new Size(75, 25);
            button_output_mp3_wav.TabIndex = 0;
            button_output_mp3_wav.Text = "Output ...";
            button_output_mp3_wav.UseVisualStyleBackColor = true;
            button_output_mp3_wav.Click += mp3_button_output_directory;
            // 
            // tab_drew_shadowplay
            // 
            tab_drew_shadowplay.Location = new Point(4, 24);
            tab_drew_shadowplay.Name = "tab_drew_shadowplay";
            tab_drew_shadowplay.Padding = new Padding(3);
            tab_drew_shadowplay.Size = new Size(565, 459);
            tab_drew_shadowplay.TabIndex = 1;
            tab_drew_shadowplay.Text = "drew shadowplay";
            tab_drew_shadowplay.UseVisualStyleBackColor = true;
            // 
            // Danverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 521);
            Controls.Add(tab_operation);
            Name = "Danverter";
            Text = "danverter";
            groupbox_select_files.ResumeLayout(false);
            groupbox_select_files.PerformLayout();
            tab_operation.ResumeLayout(false);
            tab_mp3_to_wav.ResumeLayout(false);
            groupbox_output.ResumeLayout(false);
            groupbox_output.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_browse_mp3_files;
        private GroupBox groupbox_select_files;
        private Label label_description;
        private CheckedListBox display_selected_files;
        private Button button_delete_selected_files;
        private Button button_clear;
        private TabControl tab_operation;
        private TabPage tab_mp3_to_wav;
        private TabPage tab_drew_shadowplay;
        private GroupBox groupbox_output;
        private Button button_output_mp3_wav;
        private TextBox textBox1;
    }
}
