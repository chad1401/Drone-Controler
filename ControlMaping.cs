using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class JoyDirSetting
    {
        public int joySetting = 0;
        public int isInverted = 0;

        JoyDirSetting(int joySetting, int isInverted)
        {
            this.joySetting = joySetting;
            this.isInverted = isInverted;
        }
    }
    public class JoyJson
    {
        public JoyDirSetting x;
        public JoyDirSetting y;

        public JoyJson(JoyDirSetting x, JoyDirSetting y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class TriJson
    {
        public int pos1;
        public int pos2;
        public int pos3;

        public TriJson(int pos1, int pos2, int pos3)
        {
            this.pos1 = pos1;
            this.pos2 = pos2;
            this.pos3 = pos3;
        }
    }
    public class ToggleJson
    {
        public int pos1;
        public int pos2;

        public ToggleJson(int pos1, int pos2)
        {
            this.pos1 = pos1;
            this.pos2 = pos2;
        }
    }
    public class PotentJson
    {
        public int setting;

        public PotentJson(int setting)
        {
            this.setting = setting;
        }
    }
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

        object joyJsonMap = new Dictionary<string, int>()
        {
            {"Yaw", 0},
            {"Pitch", 1},
            {"Roll", 2},
            {"Forward", 3},
            {"Back", 4},
            {"Left", 5},
            {"Right", 6}
        };
        object switchJsonMap = new Dictionary<string, int>()
        {
            {"Drone E-stop A", 0},
            {"Drone E-stop B", 1},
            {"Flight Mode A", 2},
            {"Flight Mode B", 3},
            {"High Sensitivity", 4},
            {"Low Sensitivity", 5}
        };
        object potentJsonMap = new Dictionary<string, int>()
        {
            {"Drone Sensitivity", 0}
        };
        public string ToJson()
        {
            return "";
        }
    }
}


