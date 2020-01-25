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
    public partial class MetersToEnglishForm : Form
    {
        public MetersToEnglishForm()
        {
            InitializeComponent();
        }

        //Closes the form
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Calculates a conversion from entered amount of meters to inches and sends off to be displayed
        private void ConvertToInchesButton_Click(object sender, EventArgs e)
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

                convertedValue = valueToConvert * 39.3701;

                DisplayConversion(valueToConvert, convertedValue, "inches");
            }
        }

        //Calculates a conversion from entered amount of meters to feet and sends off to be displayed
        private void ConvertToFeetButton_Click(object sender, EventArgs e)
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

                convertedValue = valueToConvert * 3.28084;

                DisplayConversion(valueToConvert, convertedValue, "feet");
            }
        }

        //Calculates a conversion from entered amount of meters to yards and sends off to be displayed
        private void ConvertToYards_Click(object sender, EventArgs e)
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

                convertedValue = valueToConvert * 1.09361;

                DisplayConversion(valueToConvert, convertedValue, "yards");
            }
        }

        //Displays original input and conversion in ResultsRichTextBox
        private void DisplayConversion(double originalValue, double convertedValue, string units)
        {
            ResultsRichTextBox.Text = originalValue + " meters equals " + convertedValue.ToString("n2")
                                        + " " + units;
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
