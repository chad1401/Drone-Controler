using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace WindowsFormsApp3
{
    public class ControlMaping
    {
        public int controlMode { get; set; }
        public string leftJoyX { get; set; }
        public bool isLeftJoyXInverted { get; set; }
        public string leftJoyY { get; set; }
        public bool isLeftJoyYInverted { get; set; }
        public string rightJoyX { get; set; }
        public bool isRightJoyXInverted { get; set; }
        public string rightJoyY { get; set; }
        public bool isRightJoyYInverted { get; set; }
        public string potent1 { get; set; }
        public string potent2 { get; set; }
        public string triSwitch1Pos1 { get; set; }
        public string triSwitch1Pos2 { get; set; }
        public string triSwitch1Pos3 { get; set; }
        public string triSwitch2Pos1 { get; set; }
        public string triSwitch2Pos2 { get; set; }
        public string triSwitch2Pos3 { get; set; }
        public string toggleSwitch1Pos1 { get; set; }
        public string toggleSwitch1Pos2 { get; set; }
        public string toggleSwitch2Pos1 { get; set; }
        public string toggleSwitch2Pos2 { get; set; }
    }
}


