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
        public Form1()
        {
            InitializeComponent();
            comboBoxInit();
        }

        //adds all volume options to the combo boxes.
        private void comboBoxInit()
        {
            string[] volumeList = {"Liter", "Cubic Foot", "Gallon", "Cup", "Teaspoon"};
            for (int i = 0; i < volumeList.Length; i++)
            {
                comboBox1.Items.Add(volumeList[i]);
                comboBox2.Items.Add(volumeList[i]);
            }
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
    }
}
