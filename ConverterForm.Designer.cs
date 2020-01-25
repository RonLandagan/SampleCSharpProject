namespace HW05_RonLandagan
{
    partial class ConverterForm
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
            this.ConverterLabel1 = new System.Windows.Forms.Label();
            this.ConvertMetersButton = new System.Windows.Forms.Button();
            this.ConvertInchesButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ConverterLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConverterLabel1
            // 
            this.ConverterLabel1.AutoSize = true;
            this.ConverterLabel1.Location = new System.Drawing.Point(27, 21);
            this.ConverterLabel1.Name = "ConverterLabel1";
            this.ConverterLabel1.Size = new System.Drawing.Size(245, 13);
            this.ConverterLabel1.TabIndex = 0;
            this.ConverterLabel1.Text = "This application converts meters to various English";
            // 
            // ConvertMetersButton
            // 
            this.ConvertMetersButton.Location = new System.Drawing.Point(12, 77);
            this.ConvertMetersButton.Name = "ConvertMetersButton";
            this.ConvertMetersButton.Size = new System.Drawing.Size(75, 41);
            this.ConvertMetersButton.TabIndex = 1;
            this.ConvertMetersButton.Text = "Convert Meters";
            this.ConvertMetersButton.UseVisualStyleBackColor = true;
            this.ConvertMetersButton.Click += new System.EventHandler(this.ConvertMetersButton_Click);
            // 
            // ConvertInchesButton
            // 
            this.ConvertInchesButton.Location = new System.Drawing.Point(106, 77);
            this.ConvertInchesButton.Name = "ConvertInchesButton";
            this.ConvertInchesButton.Size = new System.Drawing.Size(75, 41);
            this.ConvertInchesButton.TabIndex = 2;
            this.ConvertInchesButton.Text = "Convert Inches";
            this.ConvertInchesButton.UseVisualStyleBackColor = true;
            this.ConvertInchesButton.Click += new System.EventHandler(this.ConvertInchesButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(197, 77);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 41);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ConverterLabel2
            // 
            this.ConverterLabel2.AutoSize = true;
            this.ConverterLabel2.Location = new System.Drawing.Point(47, 34);
            this.ConverterLabel2.Name = "ConverterLabel2";
            this.ConverterLabel2.Size = new System.Drawing.Size(195, 13);
            this.ConverterLabel2.TabIndex = 4;
            this.ConverterLabel2.Text = "units, and inches to various metric units.";
            // 
            // ConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.ConverterLabel2);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ConvertInchesButton);
            this.Controls.Add(this.ConvertMetersButton);
            this.Controls.Add(this.ConverterLabel1);
            this.Name = "ConverterForm";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConverterLabel1;
        private System.Windows.Forms.Button ConvertMetersButton;
        private System.Windows.Forms.Button ConvertInchesButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label ConverterLabel2;
    }
}

