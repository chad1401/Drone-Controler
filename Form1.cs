using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class DroneControler : Form
    {
        private ControlMaping mapping;
        public DroneControler()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
             
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void DroneControler_Load(object sender, EventArgs e)
        {
            mapping = new ControlMaping();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.leftJoyX = comboBox1.SelectedItem.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.leftJoyY = comboBox2.SelectedItem.ToString();
        }
        
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.rightJoyX = comboBox4.SelectedItem.ToString();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.rightJoyY = comboBox3.SelectedItem.ToString();
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.triSwitch1Pos1 = comboBox12.SelectedItem.ToString();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.triSwitch1Pos2 = comboBox11.SelectedItem.ToString();
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.triSwitch1Pos3 = comboBox13.SelectedItem.ToString();
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.triSwitch2Pos1 = comboBox16.SelectedItem.ToString();
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.triSwitch2Pos2 = comboBox15.SelectedItem.ToString();
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.triSwitch2Pos3 = comboBox14.SelectedItem.ToString();
        }

        private void comboBox9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            mapping.potent1 = comboBox9.SelectedItem.ToString();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.potent2 = comboBox10.SelectedItem.ToString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.toggleSwitch1Pos1 = comboBox6.SelectedItem.ToString();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.toggleSwitch1Pos2 = comboBox6.SelectedItem.ToString();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.toggleSwitch2Pos1 = comboBox7.SelectedItem.ToString();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapping.toggleSwitch2Pos2 = comboBox8.SelectedItem.ToString();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            mapping.isLeftJoyXInverted = checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            mapping.isLeftJoyYInverted = checkBox6.Checked;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            mapping.isRightJoyXInverted= checkBox8.Checked;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            mapping.isRightJoyYInverted = checkBox7.Checked;
        }
    }
}
