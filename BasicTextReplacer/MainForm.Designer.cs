namespace BasicTextReplacer {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LoadFileButton = new System.Windows.Forms.Button();
            this.PreviewLabel = new System.Windows.Forms.Label();
            this.PreviewTextBox = new System.Windows.Forms.TextBox();
            this.ReplacementsPanel = new System.Windows.Forms.Panel();
            this.ReplacementsLabel = new System.Windows.Forms.Label();
            this.ExportClipboardButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadFileButton
            // 
            this.LoadFileButton.Location = new System.Drawing.Point(12, 12);
            this.LoadFileButton.Name = "LoadFileButton";
            this.LoadFileButton.Size = new System.Drawing.Size(75, 23);
            this.LoadFileButton.TabIndex = 0;
            this.LoadFileButton.Text = "Load File...";
            this.LoadFileButton.UseVisualStyleBackColor = true;
            this.LoadFileButton.Click += new System.EventHandler(this.LoadFileButton_Click);
            // 
            // PreviewLabel
            // 
            this.PreviewLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewLabel.AutoSize = true;
            this.PreviewLabel.Location = new System.Drawing.Point(12, 53);
            this.PreviewLabel.Name = "PreviewLabel";
            this.PreviewLabel.Size = new System.Drawing.Size(48, 15);
            this.PreviewLabel.TabIndex = 2;
            this.PreviewLabel.Text = "Preview";
            // 
            // PreviewTextBox
            // 
            this.PreviewTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviewTextBox.Location = new System.Drawing.Point(12, 71);
            this.PreviewTextBox.Multiline = true;
            this.PreviewTextBox.Name = "PreviewTextBox";
            this.PreviewTextBox.ReadOnly = true;
            this.PreviewTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PreviewTextBox.Size = new System.Drawing.Size(597, 367);
            this.PreviewTextBox.TabIndex = 3;
            // 
            // ReplacementsPanel
            // 
            this.ReplacementsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplacementsPanel.AutoScroll = true;
            this.ReplacementsPanel.Location = new System.Drawing.Point(615, 71);
            this.ReplacementsPanel.Name = "ReplacementsPanel";
            this.ReplacementsPanel.Size = new System.Drawing.Size(222, 367);
            this.ReplacementsPanel.TabIndex = 4;
            // 
            // ReplacementsLabel
            // 
            this.ReplacementsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ReplacementsLabel.AutoSize = true;
            this.ReplacementsLabel.Location = new System.Drawing.Point(615, 53);
            this.ReplacementsLabel.Name = "ReplacementsLabel";
            this.ReplacementsLabel.Size = new System.Drawing.Size(81, 15);
            this.ReplacementsLabel.TabIndex = 5;
            this.ReplacementsLabel.Text = "Replacements";
            this.ReplacementsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ExportClipboardButton
            // 
            this.ExportClipboardButton.Location = new System.Drawing.Point(93, 12);
            this.ExportClipboardButton.Name = "ExportClipboardButton";
            this.ExportClipboardButton.Size = new System.Drawing.Size(120, 23);
            this.ExportClipboardButton.TabIndex = 6;
            this.ExportClipboardButton.Text = "Export To Clipboard";
            this.ExportClipboardButton.UseVisualStyleBackColor = true;
            this.ExportClipboardButton.Click += new System.EventHandler(this.ExportClipboardButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.ExportClipboardButton);
            this.Controls.Add(this.ReplacementsLabel);
            this.Controls.Add(this.ReplacementsPanel);
            this.Controls.Add(this.PreviewTextBox);
            this.Controls.Add(this.PreviewLabel);
            this.Controls.Add(this.LoadFileButton);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MainForm";
            this.Text = "Text Replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LoadFileButton;
        private Label PreviewLabel;
        private TextBox PreviewTextBox;
        private Panel ReplacementsPanel;
        private Label ReplacementsLabel;
        private Button ExportClipboardButton;
    }
}