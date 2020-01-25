using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace HW05_RonLandagan
{
    public partial class InchesToMetricForm : Form
    {
        public InchesToMetricForm()
        {
            InitializeComponent();
        }

        //Closes the form
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Calculates a conversion from entered amount of inches to millimeters and sends off to be displayed
        private void ConvertToMillimetersButton_Click(object sender, EventArgs e)
        {
            if (EntryTextBox.Text == "")
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Please enter a number", "Error");
            }
            else
            {
                double valueToConvert = double.Parse(EntryTextBox.Text),
                    convertedValue;

                convertedValue = valueToConvert * 25.4;

                DisplayConversion(valueToConvert, convertedValue, "millimeters");
            }
        }

        //Calculates a conversion from entered amount of inches to centimeters and sends off to be displayed
        private void ConvertToCentimetersButton_Click(object sender, EventArgs e)
        {
            if (EntryTextBox.Text == "")
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Please enter a number", "Error");
            }
            else
            {
                double valueToConvert = double.Parse(EntryTextBox.Text),
                convertedValue;

                convertedValue = valueToConvert * 2.54;

                DisplayConversion(valueToConvert, convertedValue, "centimeters");
            }
        }

        //Calculates a conversion from entered amount of inches to meters and sends off to be displayed
        private void ConvertToMetersButton_Click(object sender, EventArgs e)
        {
            if (EntryTextBox.Text == "")
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Please enter a number", "Error");
            }
            else
            {
                double valueToConvert = double.Parse(EntryTextBox.Text),
                convertedValue;

                convertedValue = valueToConvert * 0.0254;

                DisplayConversion(valueToConvert, convertedValue, "meters");
            }
        }

        //Calculates a conversion from entered amount of inches to micrometers and sends off to be displayed
        private void ConvertToMicronsButton_Click(object sender, EventArgs e)
        {
            if (EntryTextBox.Text == "")
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Please enter a number", "Error");
            }
            else
            {
                double valueToConvert = double.Parse(EntryTextBox.Text),
                convertedValue;

                convertedValue = valueToConvert * 25400;

                DisplayConversion(valueToConvert, convertedValue, "microns");
            }
        }

        //Displays original input and conversion in ResultsRichTextBox
        private void DisplayConversion(double originalValue, double convertedValue, string units)
        {
            ResultsRichTextBox.Text = originalValue + " inches equals " + convertedValue
                                        + " " + units;
        }

        private void InchesToMetricForm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void InchesToMetricForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        //Validates user input by preventing unnecessary keys from being pushed
        //Only allows numeric, decimal, delete, backspace, and period keys to be pressed
        private void EntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && e.Modifiers != Keys.Shift)
            {                
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9 && e.Modifiers != Keys.Shift)
            {
            }
            else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
            }
            //If anything else is pressed, the input is suppressed and a beep will sound
            else
            {
                e.SuppressKeyPress = true;
                SystemSounds.Beep.Play();
            }
        }
    }
}
