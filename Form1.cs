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
        private Http comunicator;
        public DroneControler()
        {
            InitializeComponent();
        }

        private void DroneControler_Load(object sender, EventArgs e)
        {
            mapping = new ControlMaping();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            mapping = JsonSerializer.Deserialize<ControlMaping>(read());

            JoyStick1.SelectedIndex = JoyStick1.FindStringExact(mapping.leftJoy);
            JoyStick2.SelectedIndex = JoyStick1.FindStringExact(mapping.rightJoy);

            TriSwitch1.SelectedIndex = TriSwitch1.FindStringExact(mapping.triSwitch1);
            TriSwitch2.SelectedIndex = TriSwitch2.FindStringExact(mapping.triSwitch2);

            Pot1.SelectedIndex = Pot1.FindStringExact(mapping.pot1);
            Pot2.SelectedIndex = Pot2.FindStringExact(mapping.pot2);

            Toggle1.SelectedIndex = Toggle1.FindStringExact(mapping.toggleSwitch1);
            Toggle2.SelectedIndex = Toggle2.FindStringExact(mapping.toggleSwitch2);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mapping.leftJoy = JoyStick1.SelectedItem.ToString();
            mapping.rightJoy = JoyStick2.SelectedItem.ToString();

            mapping.triSwitch1 = TriSwitch1.SelectedItem.ToString();
            mapping.triSwitch2 = TriSwitch2.SelectedItem.ToString();


            mapping.pot1 = Pot1.SelectedItem.ToString();
            mapping.pot2 = Pot2.SelectedItem.ToString();

            mapping.toggleSwitch1 = Toggle1.SelectedItem.ToString();
            mapping.toggleSwitch2 = Toggle2.SelectedItem.ToString();

            mapping.isLeftJoyInverted = checkBox5.Checked;
            mapping.isRightJoyInverted = checkBox8.Checked;

            string jsonString = JsonSerializer.Serialize<ControlMaping>(mapping);
            write(jsonString);
            comunicator.URI = URIBox.Text;
            comunicator.PostData(jsonString);

        }



        void write(string str) {
            File.WriteAllLines("Save.txt", new[] {str});
        }
        string read(){
            string content = File.ReadAllText("Save.txt");
            return content;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comunicator.PostData("Calibrate");
        }
    }
}
