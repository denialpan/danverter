namespace danverter
{
    partial class danverter
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
            SuspendLayout();
            // 
            // button_browse_files
            // 
            button_browse_files.Location = new Point(12, 12);
            button_browse_files.Name = "button_browse_files";
            button_browse_files.Size = new Size(75, 23);
            button_browse_files.TabIndex = 0;
            button_browse_files.Text = "Browse ...";
            button_browse_files.UseVisualStyleBackColor = true;
            button_browse_files.Click += button_browse_files_click;
            // 
            // danverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_browse_files);
            Name = "danverter";
            Text = "danverter";
            ResumeLayout(false);
        }

        #endregion

        private Button button_browse_files;
    }
}
