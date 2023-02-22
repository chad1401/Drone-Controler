using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class ControlMaping
    {
        public int controlMode = 1;
        public string leftJoyX = "";
        public bool isLeftJoyXInverted = false;
        public string leftJoyY = "";
        public bool isLeftJoyYInverted = false;
        public string rightJoyX = "";
        public bool isRightJoyXInverted = false;
        public string rightJoyY = "";
        public bool isRightJoyYInverted = false;
        public string potent1 = "";
        public string potent2 = "";
        public string triSwitch1Pos1 = "";
        public string triSwitch1Pos2 = "";
        public string triSwitch1Pos3 = "";
        public string triSwitch2Pos1 = "";
        public string triSwitch2Pos2 = "";
        public string triSwitch2Pos3 = "";
        public string toggleSwitch1Pos1 = "";
        public string toggleSwitch1Pos2 = "";
        public string toggleSwitch2Pos1 = "";
        public string toggleSwitch2Pos2 = "";



        public string stringToNum(string s) {
            if (s == "yaw") { return 3.ToString(); }
            
            return ""; 
        }
        public string toJsn() {
            string s = "{" +
            "leftJoyX" + stringToNum(leftJoyX) + "," +
            "leftJoyY" + stringToNum(leftJoyY) + "," +
            "}";

            return s; 
        }
    }
}


