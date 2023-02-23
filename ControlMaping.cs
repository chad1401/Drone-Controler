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
        public string boolToNum(bool b)
        {
            return b ? 1.ToString() : 0.ToString();
        }
        public string toJsn() {
            string s = "{" +
            "\"controlMode\": " + controlMode.ToString() + ", " +
            "\"leftJoyX\": " + stringToNum(leftJoyX) + ", " +
            "\"isLeftJoyXInverted\": " + boolToNum(isLeftJoyXInverted) + ", " +
            "\"leftJoyY\": " + stringToNum(leftJoyY) + ", " +
            "\"isLeftJoyYInverted\": " + boolToNum(isLeftJoyYInverted) + ", " +
            "\"rightJoyX\": " + stringToNum(rightJoyX) + ", " +
            "\"isRightJoyXInverted\": " + boolToNum(isRightJoyXInverted) + ", " +
            "\"rightJoyY\": " + stringToNum(leftJoyX) + ", " +
            "\"isRightJoyYInverted\": " + boolToNum(isRightJoyYInverted) + ", " +
            "\"potent1\": " + stringToNum(potent1) + ", " +
            "\"potent2\": " + stringToNum(potent2) + ", " +
            "\"triSwitch1Pos1\": " + stringToNum(triSwitch1Pos1) + ", " +
            "\"triSwitch1Pos2\": " + stringToNum(triSwitch1Pos2) + ", " +
            "\"triSwitch1Pos3\": " + stringToNum(triSwitch1Pos3) + ", " +
            "\"triSwitch2Pos1\": " + stringToNum(triSwitch2Pos1) + ", " +
            "\"triSwitch2Pos2\": " + stringToNum(triSwitch2Pos2) + ", " +
            "\"triSwitch2Pos3\": " + stringToNum(triSwitch2Pos3) + ", " +
            "\"toggleSwitch1Pos1\": " + stringToNum(toggleSwitch1Pos1) + ", " +
            "\"toggleSwitch1Pos2\": " + stringToNum(toggleSwitch1Pos2) + ", " +
            "\"toggleSwitch2Pos1\": " + stringToNum(toggleSwitch2Pos1) + ", " +
            "\"toggleSwitch2Pos2\": " + stringToNum(toggleSwitch2Pos2) + ", " +
            "}";

            return s; 
        }
    }
}


