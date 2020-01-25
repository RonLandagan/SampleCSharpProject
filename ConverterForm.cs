using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW05_RonLandagan
{
    public partial class ConverterForm : Form
    {
        public ConverterForm()
        {
            InitializeComponent();
        }

        //Closes the program
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Creates an instance of the MetersToEnglish Form
        private void ConvertMetersButton_Click(object sender, EventArgs e)
        {
            Form ConvertMeters = new MetersToEnglishForm();
            ConvertMeters.ShowDialog();
        }

        //Creates an instance of the InchesToMetric Form
        private void ConvertInchesButton_Click(object sender, EventArgs e)
        {
            Form ConvertInches = new InchesToMetricForm();
            ConvertInches.ShowDialog();
        }
    }
}
