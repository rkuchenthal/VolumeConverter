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
            textBox2.Enabled= false;
            comboBoxInit();
        }

        //adds all volume options to the combo boxes.
        private void comboBoxInit()
        {
            for (int i = 0; i < volumeList.Length; i++)
            {
                comboBox1.Items.Add(volumeList[i]);
                comboBox2.Items.Add(volumeList[i]);
            }
            comboBox1.Text = "Original Unit";
            comboBox2.Text = "New Unit";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string volFrom = comboBox1.SelectedItem.ToString();
            string volTo = comboBox2.SelectedItem.ToString();
            double convFrom = Convert.ToInt32(textBox1.Text);

            //liters to gallons
            if (volFrom.Equals(volumeList[0]) && volTo.Equals(volumeList[1]))
            {
                textBox2.Text = Convert.ToString(convFrom * .264172);
            }
            //gallons to liters
            else if(volFrom.Equals(volumeList[1]) && volTo.Equals(volumeList[0]))
            {
                textBox2.Text = Convert.ToString(convFrom * 3.785411784);
            }
            //liters to cups
            else if (volFrom.Equals(volumeList[0]) && volTo.Equals(volumeList[2]))
            {
                textBox2.Text = Convert.ToString(convFrom * 4.2267528377);
            }
            //gallons to cups
            else if (volFrom.Equals(volumeList[1]) && volTo.Equals(volumeList[2]))
            {
                textBox2.Text = Convert.ToString(convFrom * 16);
            }
            //cups to liters
            else if (volFrom.Equals(volumeList[2]) && volTo.Equals(volumeList[0]))
            {
                textBox2.Text = Convert.ToString(convFrom * 0.2365882365);
            }
            //cups to gallons
            else if (volFrom.Equals(volumeList[2]) && volTo.Equals(volumeList[1]))
            {
                textBox2.Text = Convert.ToString(convFrom * 0.0625);
            }




        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.Text = "Original Unit";
            comboBox2.Text = "New Unit";
        }
    }
}
