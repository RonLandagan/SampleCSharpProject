namespace HW05_RonLandagan
{
    partial class InchesToMetricForm
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
            this.InchesToMetricLabel = new System.Windows.Forms.Label();
            this.EntryTextBox = new System.Windows.Forms.TextBox();
            this.ResultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ConvertToMillimetersButton = new System.Windows.Forms.Button();
            this.ConvertToCentimetersButton = new System.Windows.Forms.Button();
            this.ConvertToMetersButton = new System.Windows.Forms.Button();
            this.ConvertToMicronsButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InchesToMetricLabel
            // 
            this.InchesToMetricLabel.AutoSize = true;
            this.InchesToMetricLabel.Location = new System.Drawing.Point(13, 15);
            this.InchesToMetricLabel.Name = "InchesToMetricLabel";
            this.InchesToMetricLabel.Size = new System.Drawing.Size(137, 13);
            this.InchesToMetricLabel.TabIndex = 0;
            this.InchesToMetricLabel.Text = "Enter the number of inches:";
            // 
            // EntryTextBox
            // 
            this.EntryTextBox.Location = new System.Drawing.Point(156, 12);
            this.EntryTextBox.Name = "EntryTextBox";
            this.EntryTextBox.Size = new System.Drawing.Size(100, 20);
            this.EntryTextBox.TabIndex = 1;
            this.EntryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EntryTextBox_KeyDown);
            // 
            // ResultsRichTextBox
            // 
            this.ResultsRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultsRichTextBox.Location = new System.Drawing.Point(156, 186);
            this.ResultsRichTextBox.Name = "ResultsRichTextBox";
            this.ResultsRichTextBox.Size = new System.Drawing.Size(100, 41);
            this.ResultsRichTextBox.TabIndex = 2;
            this.ResultsRichTextBox.Text = "";
            // 
            // ConvertToMillimetersButton
            // 
            this.ConvertToMillimetersButton.Location = new System.Drawing.Point(24, 57);
            this.ConvertToMillimetersButton.Name = "ConvertToMillimetersButton";
            this.ConvertToMillimetersButton.Size = new System.Drawing.Size(75, 41);
            this.ConvertToMillimetersButton.TabIndex = 3;
            this.ConvertToMillimetersButton.Text = "Convert to Millimeters";
            this.ConvertToMillimetersButton.UseVisualStyleBackColor = true;
            this.ConvertToMillimetersButton.Click += new System.EventHandler(this.ConvertToMillimetersButton_Click);
            // 
            // ConvertToCentimetersButton
            // 
            this.ConvertToCentimetersButton.Location = new System.Drawing.Point(156, 57);
            this.ConvertToCentimetersButton.Name = "ConvertToCentimetersButton";
            this.ConvertToCentimetersButton.Size = new System.Drawing.Size(75, 41);
            this.ConvertToCentimetersButton.TabIndex = 4;
            this.ConvertToCentimetersButton.Text = "Convert to Centimeters";
            this.ConvertToCentimetersButton.UseVisualStyleBackColor = true;
            this.ConvertToCentimetersButton.Click += new System.EventHandler(this.ConvertToCentimetersButton_Click);
            // 
            // ConvertToMetersButton
            // 
            this.ConvertToMetersButton.Location = new System.Drawing.Point(24, 122);
            this.ConvertToMetersButton.Name = "ConvertToMetersButton";
            this.ConvertToMetersButton.Size = new System.Drawing.Size(75, 41);
            this.ConvertToMetersButton.TabIndex = 5;
            this.ConvertToMetersButton.Text = "Convert to Meters";
            this.ConvertToMetersButton.UseVisualStyleBackColor = true;
            this.ConvertToMetersButton.Click += new System.EventHandler(this.ConvertToMetersButton_Click);
            // 
            // ConvertToMicronsButton
            // 
            this.ConvertToMicronsButton.Location = new System.Drawing.Point(156, 122);
            this.ConvertToMicronsButton.Name = "ConvertToMicronsButton";
            this.ConvertToMicronsButton.Size = new System.Drawing.Size(75, 41);
            this.ConvertToMicronsButton.TabIndex = 6;
            this.ConvertToMicronsButton.Text = "Convert to Microns";
            this.ConvertToMicronsButton.UseVisualStyleBackColor = true;
            this.ConvertToMicronsButton.Click += new System.EventHandler(this.ConvertToMicronsButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(24, 186);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 41);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // InchesToMetricForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.ConvertToMicronsButton);
            this.Controls.Add(this.ConvertToMetersButton);
            this.Controls.Add(this.ConvertToCentimetersButton);
            this.Controls.Add(this.ConvertToMillimetersButton);
            this.Controls.Add(this.ResultsRichTextBox);
            this.Controls.Add(this.EntryTextBox);
            this.Controls.Add(this.InchesToMetricLabel);
            this.Name = "InchesToMetricForm";
            this.Text = "Inches To Metric";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InchesToMetricLabel;
        private System.Windows.Forms.TextBox EntryTextBox;
        private System.Windows.Forms.RichTextBox ResultsRichTextBox;
        private System.Windows.Forms.Button ConvertToMillimetersButton;
        private System.Windows.Forms.Button ConvertToCentimetersButton;
        private System.Windows.Forms.Button ConvertToMetersButton;
        private System.Windows.Forms.Button ConvertToMicronsButton;
        private System.Windows.Forms.Button CloseButton;
    }
}