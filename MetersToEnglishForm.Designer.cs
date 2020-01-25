namespace HW05_RonLandagan
{
    partial class MetersToEnglishForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MetersToEnglishLabel = new System.Windows.Forms.Label();
            this.EntryTextBox = new System.Windows.Forms.TextBox();
            this.ConvertToInchesButton = new System.Windows.Forms.Button();
            this.ConvertToFeetButton = new System.Windows.Forms.Button();
            this.ConvertToYards = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MetersToEnglishLabel
            // 
            this.MetersToEnglishLabel.AutoSize = true;
            this.MetersToEnglishLabel.Location = new System.Drawing.Point(13, 27);
            this.MetersToEnglishLabel.Name = "MetersToEnglishLabel";
            this.MetersToEnglishLabel.Size = new System.Drawing.Size(137, 13);
            this.MetersToEnglishLabel.TabIndex = 0;
            this.MetersToEnglishLabel.Text = "Enter the number of meters:";
            // 
            // EntryTextBox
            // 
            this.EntryTextBox.Location = new System.Drawing.Point(156, 24);
            this.EntryTextBox.Name = "EntryTextBox";
            this.EntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.EntryTextBox.TabIndex = 1;
            this.EntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntryTextBox_KeyDown);
            // 
            // ConvertToInchesButton
            // 
            this.ConvertToInchesButton.Location = new System.Drawing.Point(16, 71);
            this.ConvertToInchesButton.Name = "ConvertToInchesButton";
            this.ConvertToInchesButton.Size = new System.Drawing.Size(75, 41);
            this.ConvertToInchesButton.TabIndex = 2;
            this.ConvertToInchesButton.Text = "Convert to Inches";
            this.ConvertToInchesButton.UseVisualStyleBackColor = true;
            this.ConvertToInchesButton.Click += new System.EventHandler(this.ConvertToInchesButton_Click);
            // 
            // ConvertToFeetButton
            // 
            this.ConvertToFeetButton.Location = new System.Drawing.Point(16, 131);
            this.ConvertToFeetButton.Name = "ConvertToFeetButton";
            this.ConvertToFeetButton.Size = new System.Drawing.Size(75, 41);
            this.ConvertToFeetButton.TabIndex = 3;
            this.ConvertToFeetButton.Text = "Convert to Feet";
            this.ConvertToFeetButton.UseVisualStyleBackColor = true;
            this.ConvertToFeetButton.Click += new System.EventHandler(this.ConvertToFeetButton_Click);
            // 
            // ConvertToYards
            // 
            this.ConvertToYards.Location = new System.Drawing.Point(16, 188);
            this.ConvertToYards.Name = "ConvertToYards";
            this.ConvertToYards.Size = new System.Drawing.Size(75, 41);
            this.ConvertToYards.TabIndex = 4;
            this.ConvertToYards.Text = "Convert to Yards";
            this.ConvertToYards.UseVisualStyleBackColor = true;
            this.ConvertToYards.Click += new System.EventHandler(this.ConvertToYards_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(156, 188);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 41);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ResultsRichTextBox
            // 
            this.ResultsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultsRichTextBox.Location = new System.Drawing.Point(156, 131);
            this.ResultsRichTextBox.Name = "ResultsRichTextBox";
            this.ResultsRichTextBox.Size = new System.Drawing.Size(100, 41);
            this.ResultsRichTextBox.TabIndex = 6;
            this.ResultsRichTextBox.Text = "";
            // 
            // MetersToEnglishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.ResultsRichTextBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ConvertToYards);
            this.Controls.Add(this.ConvertToFeetButton);
            this.Controls.Add(this.ConvertToInchesButton);
            this.Controls.Add(this.EntryTextBox);
            this.Controls.Add(this.MetersToEnglishLabel);
            this.MinimizeBox = false;
            this.Name = "MetersToEnglishForm";
            this.Text = "Meters To English";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MetersToEnglishLabel;
        private System.Windows.Forms.TextBox EntryTextBox;
        private System.Windows.Forms.Button ConvertToInchesButton;
        private System.Windows.Forms.Button ConvertToFeetButton;
        private System.Windows.Forms.Button ConvertToYards;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.RichTextBox ResultsRichTextBox;
    }
}