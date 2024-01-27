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
            button_browse_files = new Button();
            groupbox_select_files = new GroupBox();
            button_clear = new Button();
            button_delete_selected_files = new Button();
            display_selected_files = new CheckedListBox();
            label_description = new Label();
            groupbox_select_files.SuspendLayout();
            SuspendLayout();
            // 
            // button_browse_files
            // 
            button_browse_files.Location = new Point(6, 22);
            button_browse_files.Name = "button_browse_files";
            button_browse_files.Size = new Size(75, 23);
            button_browse_files.TabIndex = 0;
            button_browse_files.Text = "Browse ...";
            button_browse_files.UseVisualStyleBackColor = true;
            button_browse_files.Click += button_browse_files_click;
            // 
            // groupbox_select_files
            // 
            groupbox_select_files.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupbox_select_files.Controls.Add(button_clear);
            groupbox_select_files.Controls.Add(button_delete_selected_files);
            groupbox_select_files.Controls.Add(display_selected_files);
            groupbox_select_files.Controls.Add(label_description);
            groupbox_select_files.Controls.Add(button_browse_files);
            groupbox_select_files.Location = new Point(12, 12);
            groupbox_select_files.Name = "groupbox_select_files";
            groupbox_select_files.Size = new Size(776, 311);
            groupbox_select_files.TabIndex = 1;
            groupbox_select_files.TabStop = false;
            groupbox_select_files.Text = "Select Files";
            // 
            // button_clear
            // 
            button_clear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_clear.Location = new Point(695, 223);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(75, 23);
            button_clear.TabIndex = 5;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_click;
            // 
            // button_delete_selected_files
            // 
            button_delete_selected_files.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_delete_selected_files.Location = new Point(571, 223);
            button_delete_selected_files.Name = "button_delete_selected_files";
            button_delete_selected_files.Size = new Size(118, 23);
            button_delete_selected_files.TabIndex = 4;
            button_delete_selected_files.Text = "Delete selected";
            button_delete_selected_files.UseVisualStyleBackColor = true;
            button_delete_selected_files.Click += button_delete_selected_files_click;
            // 
            // display_selected_files
            // 
            display_selected_files.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            display_selected_files.FormattingEnabled = true;
            display_selected_files.Location = new Point(6, 51);
            display_selected_files.Name = "display_selected_files";
            display_selected_files.Size = new Size(764, 166);
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
            // Danverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupbox_select_files);
            Name = "Danverter";
            Text = "danverter";
            groupbox_select_files.ResumeLayout(false);
            groupbox_select_files.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button_browse_files;
        private GroupBox groupbox_select_files;
        private Label label_description;
        private CheckedListBox display_selected_files;
        private Button button_delete_selected_files;
        private Button button_clear;
    }
}
