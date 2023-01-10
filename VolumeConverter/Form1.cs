using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VolumeConverter
{
    public partial class Form1 : Form
    {
        private string[] volumeList = { "Liter", "Gallon", "Cup" };
        public Form1()
        {
            InitializeComponent();
            answerVolTextBox.Enabled= false;
            comboBoxInit();
        }

        //adds all volume options to the combo boxes.
        private void comboBoxInit()
        {
            for (int i = 0; i < volumeList.Length; i++)
            {
                convertingFromTextBox.Items.Add(volumeList[i]);
                convertToDropDown.Items.Add(volumeList[i]);
            }
            convertingFromTextBox.Text = "Original Unit";
            convertToDropDown.Text = "New Unit";
        }
       
    private void button1_Click(object sender, EventArgs e)
        {
            //check to make sure the text boxes arent empty,
            //if so not allowing the program to continue
            if (String.IsNullOrEmpty(initVolTextBox.Text)) { return; }

            //extract all text from comboboxes and textboxes
            string volFrom = convertingFromTextBox.SelectedItem.ToString();
            string volTo = convertToDropDown.SelectedItem.ToString();
            double convFrom = Convert.ToInt32(initVolTextBox.Text);

            //CONVERSIONS
            //liters to gallons
            if (volFrom.Equals(volumeList[0]) && volTo.Equals(volumeList[1]))
            {
                answerVolTextBox.Text = Convert.ToString(convFrom * .264172);
            }
            //gallons to liters
            else if (volFrom.Equals(volumeList[1]) && volTo.Equals(volumeList[0]))
            {
                answerVolTextBox.Text = Convert.ToString(convFrom * 3.785411784);
            }
            //liters to cups
            else if (volFrom.Equals(volumeList[0]) && volTo.Equals(volumeList[2]))
            {
                answerVolTextBox.Text = Convert.ToString(convFrom * 4.2267528377);
            }
            //gallons to cups
            else if (volFrom.Equals(volumeList[1]) && volTo.Equals(volumeList[2]))
            {
                answerVolTextBox.Text = Convert.ToString(convFrom * 16);
            }
            //cups to liters
            else if (volFrom.Equals(volumeList[2]) && volTo.Equals(volumeList[0]))
            {
                answerVolTextBox.Text = Convert.ToString(convFrom * 0.2365882365);
            }
            //cups to gallons
            else if (volFrom.Equals(volumeList[2]) && volTo.Equals(volumeList[1]))
            {
                answerVolTextBox.Text = Convert.ToString(convFrom * 0.0625);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            initVolTextBox.Text = string.Empty;
            answerVolTextBox.Text = string.Empty;
            convertingFromTextBox.Text = "Original Unit";
            convertToDropDown.Text = "New Unit";
        }
    }
}
