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
using System.Diagnostics;

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
            comunicator = new Http();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            mapping = JsonSerializer.Deserialize<ControlMaping>(read());

            JoyStick1X.SelectedIndex = JoyStick1X.FindStringExact("Channel " + mapping.xGim1);
            JoyStick2X.SelectedIndex = JoyStick1X.FindStringExact("Channel " + mapping.xGim2);

            JoyStick1Y.SelectedIndex = JoyStick1X.FindStringExact("Channel " + mapping.yGim1);
            JoyStick2Y.SelectedIndex = JoyStick1X.FindStringExact("Channel " + mapping.yGim2);

            TriSwitch1.SelectedIndex = TriSwitch1.FindStringExact("Channel " + mapping.tri_sw1);
            TriSwitch2.SelectedIndex = TriSwitch2.FindStringExact("Channel " + mapping.tri_sw2);

            Pot1.SelectedIndex = Pot1.FindStringExact( "Channel "+ mapping.pot1);
            Pot2.SelectedIndex = Pot2.FindStringExact("Channel " + mapping.pot2);

            Toggle1.SelectedIndex = Toggle1.FindStringExact("Channel " + mapping.bi_sw1);
            Toggle2.SelectedIndex = Toggle2.FindStringExact("Channel " + mapping.bi_sw2);


            Btn1.SelectedIndex = Btn1.FindStringExact("Channel " + mapping.but1);
            Btn2.SelectedIndex = Btn2.FindStringExact("Channel " + mapping.but2);


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            mapping.xGim1 = JoyStick1X.SelectedItem.ToString().Remove(0,8);
            mapping.xGim2 = JoyStick2X.SelectedItem.ToString().Remove(0, 8);

            mapping.yGim1 = JoyStick1Y.SelectedItem.ToString().Remove(0, 8);
            mapping.yGim2 = JoyStick2Y.SelectedItem.ToString().Remove(0, 8);

            mapping.tri_sw1 = TriSwitch1.SelectedItem.ToString().Remove(0, 8);
            mapping.tri_sw2 = TriSwitch2.SelectedItem.ToString().Remove(0, 8);


            mapping.pot1 = Pot1.SelectedItem.ToString().Remove(0, 8);
            mapping.pot2 = Pot2.SelectedItem.ToString().Remove(0, 8);

            mapping.bi_sw1 = Toggle1.SelectedItem.ToString().Remove(0, 8);
            mapping.bi_sw2 = Toggle2.SelectedItem.ToString().Remove(0, 8);

            mapping.but1 = Btn1.SelectedItem.ToString().Remove(0, 8);
            mapping.but2 = Btn2.SelectedItem.ToString().Remove(0, 8);

            string jsonString = JsonSerializer.Serialize<ControlMaping>(mapping);
            write(jsonString);
            if (URIBox.Text != "")
            {
                //comunicator.URI = URIBox.Text;
                //comunicator.PostData(jsonString);

                Process p = Process.Start(new ProcessStartInfo(@"HttpPostC.exe")
                {
                    Arguments = " " + URIBox.Text + " 80 POST / Save.txt",
                    WindowStyle = ProcessWindowStyle.Normal,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true
                });

            }

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
            //comunicator.PostData("Configure");

            if (URIBox.Text != "")
            {
                //comunicator.URI = URIBox.Text;
                //comunicator.PostData(jsonString);

                Process p = Process.Start(new ProcessStartInfo(@"HttpPostC.exe")
                {
                    Arguments = " " + URIBox.Text + " 80 POST / Calibrate.txt",
                    WindowStyle = ProcessWindowStyle.Normal,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardError = true
                });

            }


        }
    }
}
