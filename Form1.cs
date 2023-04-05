using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;



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
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox9_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mapping = JsonSerializer.Deserialize<ControlMaping>(read());

            comboBox1.SelectedIndex = comboBox1.FindStringExact(mapping.leftJoyX);
            comboBox2.SelectedIndex = comboBox2.FindStringExact(mapping.leftJoyY);
            comboBox4.SelectedIndex = comboBox1.FindStringExact(mapping.rightJoyX);
            comboBox3.SelectedIndex = comboBox1.FindStringExact(mapping.rightJoyY);

            comboBox12.SelectedIndex = comboBox1.FindStringExact(mapping.triSwitch1Pos1);
            comboBox11.SelectedIndex = comboBox1.FindStringExact(mapping.triSwitch1Pos2);
            comboBox13.SelectedIndex = comboBox1.FindStringExact(mapping.triSwitch1Pos3);

            comboBox16.SelectedIndex = comboBox1.FindStringExact(mapping.triSwitch2Pos1);
            comboBox15.SelectedIndex = comboBox1.FindStringExact(mapping.triSwitch2Pos2);
            comboBox14.SelectedIndex = comboBox1.FindStringExact(mapping.triSwitch2Pos3);

            comboBox9.SelectedIndex = comboBox1.FindStringExact(mapping.potent1);
            comboBox10.SelectedIndex = comboBox1.FindStringExact(mapping.potent2);

            comboBox6.SelectedIndex = comboBox1.FindStringExact(mapping.toggleSwitch1Pos1);
            comboBox5.SelectedIndex = comboBox1.FindStringExact(mapping.toggleSwitch1Pos2);

            comboBox7.SelectedIndex = comboBox1.FindStringExact(mapping.toggleSwitch2Pos1);
            comboBox8.SelectedIndex = comboBox1.FindStringExact(mapping.toggleSwitch2Pos2);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            mapping.leftJoyX = comboBox1.SelectedItem.ToString();
            mapping.leftJoyY = comboBox2.SelectedItem.ToString();
            mapping.rightJoyX = comboBox4.SelectedItem.ToString();
            mapping.rightJoyY = comboBox3.SelectedItem.ToString();
            mapping.triSwitch1Pos1 = comboBox12.SelectedItem.ToString();
            mapping.triSwitch1Pos2 = comboBox11.SelectedItem.ToString();
            mapping.triSwitch1Pos3 = comboBox13.SelectedItem.ToString();
            mapping.triSwitch2Pos1 = comboBox16.SelectedItem.ToString();
            mapping.triSwitch2Pos2 = comboBox15.SelectedItem.ToString();
            mapping.triSwitch2Pos3 = comboBox14.SelectedItem.ToString();
            mapping.potent1 = comboBox9.SelectedItem.ToString();
            mapping.potent2 = comboBox10.SelectedItem.ToString();
            mapping.toggleSwitch1Pos1 = comboBox6.SelectedItem.ToString();
            mapping.toggleSwitch1Pos2 = comboBox6.SelectedItem.ToString();
            mapping.toggleSwitch2Pos1 = comboBox7.SelectedItem.ToString();
            mapping.toggleSwitch2Pos2 = comboBox8.SelectedItem.ToString();
            mapping.isLeftJoyXInverted = checkBox5.Checked;
            mapping.isLeftJoyYInverted = checkBox6.Checked;
            mapping.isRightJoyXInverted = checkBox8.Checked;
            mapping.isRightJoyYInverted = checkBox7.Checked;

            string jsonString = JsonSerializer.Serialize<ControlMaping>(mapping);
            write(jsonString);
        }



        void write(string str) {
            File.WriteAllLines("Save.txt", new[] {str});
        }
        string read(){
            string content = File.ReadAllText("Save.txt");
            return content;
        }


    }
}
