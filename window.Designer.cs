﻿namespace danverter
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
            groupbox_select_files_mp3 = new GroupBox();
            label_number_files = new Label();
            button_clear = new Button();
            button_delete_selected_files = new Button();
            display_selected_mp3_files = new CheckedListBox();
            label_description = new Label();
            tab_operation = new TabControl();
            tab_mp3_to_wav = new TabPage();
            groupbox_output = new GroupBox();
            progress_mp3 = new ProgressBar();
            button_mp3_start = new Button();
            combobox_quality = new ComboBox();
            textbox_output_directory = new TextBox();
            button_output_mp3_wav = new Button();
            tab_drew_shadowplay = new TabPage();
            button_shadowplay_start = new Button();
            groupbox_shadowplay_settings = new GroupBox();
            tablelayout_output_options = new TableLayoutPanel();
            groupbox_mp3_options = new GroupBox();
            groupbox_mp4_options = new GroupBox();
            radiobutton_mp4 = new RadioButton();
            radiobutton_mp3 = new RadioButton();
            groupbox_select_file_shadowplay = new GroupBox();
            textbox_file_shadowplay = new TextBox();
            button_select_file_shadowplay = new Button();
            groupbox_select_files_mp3.SuspendLayout();
            tab_operation.SuspendLayout();
            tab_mp3_to_wav.SuspendLayout();
            groupbox_output.SuspendLayout();
            tab_drew_shadowplay.SuspendLayout();
            groupbox_shadowplay_settings.SuspendLayout();
            tablelayout_output_options.SuspendLayout();
            groupbox_select_file_shadowplay.SuspendLayout();
            SuspendLayout();
            // 
            // button_browse_mp3_files
            // 
            button_browse_mp3_files.Location = new Point(6, 20);
            button_browse_mp3_files.Name = "button_browse_mp3_files";
            button_browse_mp3_files.Size = new Size(75, 25);
            button_browse_mp3_files.TabIndex = 0;
            button_browse_mp3_files.Text = "Browse ...";
            button_browse_mp3_files.UseVisualStyleBackColor = true;
            button_browse_mp3_files.Click += mp3_button_browse_files_click;
            // 
            // groupbox_select_files_mp3
            // 
            groupbox_select_files_mp3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupbox_select_files_mp3.Controls.Add(label_number_files);
            groupbox_select_files_mp3.Controls.Add(button_clear);
            groupbox_select_files_mp3.Controls.Add(button_delete_selected_files);
            groupbox_select_files_mp3.Controls.Add(display_selected_mp3_files);
            groupbox_select_files_mp3.Controls.Add(label_description);
            groupbox_select_files_mp3.Controls.Add(button_browse_mp3_files);
            groupbox_select_files_mp3.Location = new Point(6, 6);
            groupbox_select_files_mp3.Name = "groupbox_select_files_mp3";
            groupbox_select_files_mp3.Size = new Size(553, 400);
            groupbox_select_files_mp3.TabIndex = 1;
            groupbox_select_files_mp3.TabStop = false;
            groupbox_select_files_mp3.Text = "Select Files";
            // 
            // label_number_files
            // 
            label_number_files.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label_number_files.AutoSize = true;
            label_number_files.Location = new Point(6, 371);
            label_number_files.Name = "label_number_files";
            label_number_files.Size = new Size(39, 15);
            label_number_files.TabIndex = 6;
            label_number_files.Text = "0 Files";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_clear.Location = new Point(472, 367);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(75, 25);
            button_clear.TabIndex = 5;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += mp3_button_clear_click;
            // 
            // button_delete_selected_files
            // 
            button_delete_selected_files.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_delete_selected_files.Location = new Point(349, 367);
            button_delete_selected_files.Name = "button_delete_selected_files";
            button_delete_selected_files.Size = new Size(118, 25);
            button_delete_selected_files.TabIndex = 4;
            button_delete_selected_files.Text = "Delete selected";
            button_delete_selected_files.UseVisualStyleBackColor = true;
            button_delete_selected_files.Click += mp3_button_delete_selected_files_click;
            // 
            // display_selected_mp3_files
            // 
            display_selected_mp3_files.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            display_selected_mp3_files.CheckOnClick = true;
            display_selected_mp3_files.FormattingEnabled = true;
            display_selected_mp3_files.Location = new Point(7, 51);
            display_selected_mp3_files.Name = "display_selected_mp3_files";
            display_selected_mp3_files.Size = new Size(539, 310);
            display_selected_mp3_files.TabIndex = 3;
            // 
            // label_description
            // 
            label_description.AutoSize = true;
            label_description.Location = new Point(87, 25);
            label_description.Name = "label_description";
            label_description.Size = new Size(156, 15);
            label_description.TabIndex = 2;
            label_description.Text = "You can select multiple files!";
            // 
            // tab_operation
            // 
            tab_operation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tab_operation.Controls.Add(tab_mp3_to_wav);
            tab_operation.Controls.Add(tab_drew_shadowplay);
            tab_operation.Location = new Point(12, 12);
            tab_operation.Name = "tab_operation";
            tab_operation.SelectedIndex = 0;
            tab_operation.Size = new Size(573, 532);
            tab_operation.TabIndex = 2;
            // 
            // tab_mp3_to_wav
            // 
            tab_mp3_to_wav.Controls.Add(groupbox_output);
            tab_mp3_to_wav.Controls.Add(groupbox_select_files_mp3);
            tab_mp3_to_wav.Location = new Point(4, 24);
            tab_mp3_to_wav.Name = "tab_mp3_to_wav";
            tab_mp3_to_wav.Padding = new Padding(3);
            tab_mp3_to_wav.Size = new Size(565, 504);
            tab_mp3_to_wav.TabIndex = 0;
            tab_mp3_to_wav.Text = "mp3 to wav";
            tab_mp3_to_wav.UseVisualStyleBackColor = true;
            // 
            // groupbox_output
            // 
            groupbox_output.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupbox_output.Controls.Add(progress_mp3);
            groupbox_output.Controls.Add(button_mp3_start);
            groupbox_output.Controls.Add(combobox_quality);
            groupbox_output.Controls.Add(textbox_output_directory);
            groupbox_output.Controls.Add(button_output_mp3_wav);
            groupbox_output.Location = new Point(6, 412);
            groupbox_output.Name = "groupbox_output";
            groupbox_output.Size = new Size(553, 86);
            groupbox_output.TabIndex = 2;
            groupbox_output.TabStop = false;
            groupbox_output.Text = "Output";
            // 
            // progress_mp3
            // 
            progress_mp3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progress_mp3.Location = new Point(7, 51);
            progress_mp3.Name = "progress_mp3";
            progress_mp3.Size = new Size(459, 23);
            progress_mp3.TabIndex = 3;
            // 
            // button_mp3_start
            // 
            button_mp3_start.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_mp3_start.Location = new Point(472, 51);
            button_mp3_start.Name = "button_mp3_start";
            button_mp3_start.Size = new Size(75, 25);
            button_mp3_start.TabIndex = 3;
            button_mp3_start.Text = "Start";
            button_mp3_start.UseVisualStyleBackColor = true;
            button_mp3_start.Click += mp3_button_start;
            // 
            // combobox_quality
            // 
            combobox_quality.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            combobox_quality.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_quality.FormattingEnabled = true;
            combobox_quality.Location = new Point(473, 22);
            combobox_quality.Name = "combobox_quality";
            combobox_quality.Size = new Size(73, 23);
            combobox_quality.TabIndex = 2;
            // 
            // textbox_output_directory
            // 
            textbox_output_directory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_output_directory.Location = new Point(87, 22);
            textbox_output_directory.Name = "textbox_output_directory";
            textbox_output_directory.ReadOnly = true;
            textbox_output_directory.Size = new Size(379, 23);
            textbox_output_directory.TabIndex = 1;
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
            tab_drew_shadowplay.Controls.Add(button_shadowplay_start);
            tab_drew_shadowplay.Controls.Add(groupbox_shadowplay_settings);
            tab_drew_shadowplay.Controls.Add(groupbox_select_file_shadowplay);
            tab_drew_shadowplay.Location = new Point(4, 24);
            tab_drew_shadowplay.Name = "tab_drew_shadowplay";
            tab_drew_shadowplay.Padding = new Padding(3);
            tab_drew_shadowplay.Size = new Size(565, 504);
            tab_drew_shadowplay.TabIndex = 1;
            tab_drew_shadowplay.Text = "drew shadowplay";
            tab_drew_shadowplay.UseVisualStyleBackColor = true;
            // 
            // button_shadowplay_start
            // 
            button_shadowplay_start.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_shadowplay_start.Location = new Point(484, 473);
            button_shadowplay_start.Name = "button_shadowplay_start";
            button_shadowplay_start.Size = new Size(75, 25);
            button_shadowplay_start.TabIndex = 2;
            button_shadowplay_start.Text = "Start";
            button_shadowplay_start.UseVisualStyleBackColor = true;
            button_shadowplay_start.Click += button_shadowplay_start_click;
            // 
            // groupbox_shadowplay_settings
            // 
            groupbox_shadowplay_settings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupbox_shadowplay_settings.Controls.Add(tablelayout_output_options);
            groupbox_shadowplay_settings.Controls.Add(radiobutton_mp4);
            groupbox_shadowplay_settings.Controls.Add(radiobutton_mp3);
            groupbox_shadowplay_settings.Location = new Point(6, 69);
            groupbox_shadowplay_settings.Name = "groupbox_shadowplay_settings";
            groupbox_shadowplay_settings.Size = new Size(553, 289);
            groupbox_shadowplay_settings.TabIndex = 2;
            groupbox_shadowplay_settings.TabStop = false;
            groupbox_shadowplay_settings.Text = "Settings";
            // 
            // tablelayout_output_options
            // 
            tablelayout_output_options.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tablelayout_output_options.ColumnCount = 2;
            tablelayout_output_options.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablelayout_output_options.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablelayout_output_options.Controls.Add(groupbox_mp3_options, 0, 0);
            tablelayout_output_options.Controls.Add(groupbox_mp4_options, 1, 0);
            tablelayout_output_options.Location = new Point(87, 13);
            tablelayout_output_options.Name = "tablelayout_output_options";
            tablelayout_output_options.RowCount = 1;
            tablelayout_output_options.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablelayout_output_options.Size = new Size(460, 270);
            tablelayout_output_options.TabIndex = 2;
            // 
            // groupbox_mp3_options
            // 
            groupbox_mp3_options.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupbox_mp3_options.Location = new Point(3, 3);
            groupbox_mp3_options.Name = "groupbox_mp3_options";
            groupbox_mp3_options.Size = new Size(224, 264);
            groupbox_mp3_options.TabIndex = 3;
            groupbox_mp3_options.TabStop = false;
            groupbox_mp3_options.Text = "mp3";
            // 
            // groupbox_mp4_options
            // 
            groupbox_mp4_options.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupbox_mp4_options.Enabled = false;
            groupbox_mp4_options.Location = new Point(233, 3);
            groupbox_mp4_options.Name = "groupbox_mp4_options";
            groupbox_mp4_options.Size = new Size(224, 264);
            groupbox_mp4_options.TabIndex = 4;
            groupbox_mp4_options.TabStop = false;
            groupbox_mp4_options.Text = "mp4";
            // 
            // radiobutton_mp4
            // 
            radiobutton_mp4.AutoSize = true;
            radiobutton_mp4.Location = new Point(18, 47);
            radiobutton_mp4.Name = "radiobutton_mp4";
            radiobutton_mp4.Size = new Size(49, 19);
            radiobutton_mp4.TabIndex = 1;
            radiobutton_mp4.TabStop = true;
            radiobutton_mp4.Text = "mp4";
            radiobutton_mp4.UseVisualStyleBackColor = true;
            radiobutton_mp4.CheckedChanged += radiobutton_mp4_CheckedChanged;
            // 
            // radiobutton_mp3
            // 
            radiobutton_mp3.AutoSize = true;
            radiobutton_mp3.Location = new Point(18, 22);
            radiobutton_mp3.Name = "radiobutton_mp3";
            radiobutton_mp3.Size = new Size(49, 19);
            radiobutton_mp3.TabIndex = 0;
            radiobutton_mp3.TabStop = true;
            radiobutton_mp3.Text = "mp3";
            radiobutton_mp3.UseVisualStyleBackColor = true;
            radiobutton_mp3.CheckedChanged += radiobutton_mp3_CheckedChanged;
            // 
            // groupbox_select_file_shadowplay
            // 
            groupbox_select_file_shadowplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupbox_select_file_shadowplay.Controls.Add(textbox_file_shadowplay);
            groupbox_select_file_shadowplay.Controls.Add(button_select_file_shadowplay);
            groupbox_select_file_shadowplay.Location = new Point(6, 6);
            groupbox_select_file_shadowplay.Name = "groupbox_select_file_shadowplay";
            groupbox_select_file_shadowplay.Size = new Size(553, 57);
            groupbox_select_file_shadowplay.TabIndex = 0;
            groupbox_select_file_shadowplay.TabStop = false;
            groupbox_select_file_shadowplay.Text = "Select Video";
            // 
            // textbox_file_shadowplay
            // 
            textbox_file_shadowplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textbox_file_shadowplay.Location = new Point(87, 21);
            textbox_file_shadowplay.Name = "textbox_file_shadowplay";
            textbox_file_shadowplay.Size = new Size(460, 23);
            textbox_file_shadowplay.TabIndex = 1;
            // 
            // button_select_file_shadowplay
            // 
            button_select_file_shadowplay.Location = new Point(6, 20);
            button_select_file_shadowplay.Name = "button_select_file_shadowplay";
            button_select_file_shadowplay.Size = new Size(75, 25);
            button_select_file_shadowplay.TabIndex = 0;
            button_select_file_shadowplay.Text = "Browse ...";
            button_select_file_shadowplay.UseVisualStyleBackColor = true;
            button_select_file_shadowplay.Click += button_select_file_shadowplay_click;
            // 
            // Danverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 556);
            Controls.Add(tab_operation);
            Name = "Danverter";
            Text = "danverter";
            groupbox_select_files_mp3.ResumeLayout(false);
            groupbox_select_files_mp3.PerformLayout();
            tab_operation.ResumeLayout(false);
            tab_mp3_to_wav.ResumeLayout(false);
            groupbox_output.ResumeLayout(false);
            groupbox_output.PerformLayout();
            tab_drew_shadowplay.ResumeLayout(false);
            groupbox_shadowplay_settings.ResumeLayout(false);
            groupbox_shadowplay_settings.PerformLayout();
            tablelayout_output_options.ResumeLayout(false);
            groupbox_select_file_shadowplay.ResumeLayout(false);
            groupbox_select_file_shadowplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_browse_mp3_files;
        private GroupBox groupbox_select_files_mp3;
        private Label label_description;
        private CheckedListBox display_selected_mp3_files;
        private Button button_delete_selected_files;
        private Button button_clear;
        private TabControl tab_operation;
        private TabPage tab_mp3_to_wav;
        private TabPage tab_drew_shadowplay;
        private GroupBox groupbox_output;
        private Button button_output_mp3_wav;
        private TextBox textbox_output_directory;
        private ComboBox combobox_quality;
        private Button button_mp3_start;
        private ProgressBar progress_mp3;
        private Label label_number_files;
        private GroupBox groupbox_select_file_shadowplay;
        private Button button_select_file_shadowplay;
        private TextBox textbox_file_shadowplay;
        private GroupBox groupbox_shadowplay_settings;
        private RadioButton radiobutton_mp4;
        private RadioButton radiobutton_mp3;
        private Button button_shadowplay_start;
        private TableLayoutPanel tablelayout_output_options;
        private GroupBox groupbox_mp3_options;
        private GroupBox groupbox_mp4_options;
    }
}
