using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class JsonConfig
    {
        public int controlMode = 0;
        public JoyJson leftJoy;
        public JoyJson rightJoy;
        public PotentJson potent1;
        public PotentJson potent2;
        public TriJson tri1;
        public TriJson tri2;
        public TriJson tri3;
        public ToggleJson tog1;
        public ToggleJson tog2;

        public JsonConfig(int controlMode, JoyJson leftJoy, JoyJson rightJoy, PotentJson potent1,
            PotentJson potent2, TriJson tri1, TriJson tri2, TriJson tri3, ToggleJson tog1,
            ToggleJson tog2)
        {
            this.controlMode = controlMode;
            this.leftJoy = leftJoy;
            this.rightJoy = rightJoy;
            this.potent1 = potent1;
            this.potent2 = potent2;
            this.tri1 = tri1;
            this.tri2 = tri2;
            this.tri3 = tri3;
            this.tog1 = tog1;
            this.tog2 = tog2;
        }
    }
    public class JoyDirSetting
    {
        public int joySetting = 0;
        public int isInverted = 0;

        public JoyDirSetting(int joySetting, int isInverted)
        {
            this.joySetting = joySetting;
            this.isInverted = isInverted;
        }
    }
    public class JoyJson
    {
        private JoyDirSetting x;
        private JoyDirSetting y;

        public JoyJson(JoyDirSetting x, JoyDirSetting y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class TriJson
    {
        private int pos1;
        private int pos2;
        private int pos3;

        public TriJson(int pos1, int pos2, int pos3)
        {
            this.pos1 = pos1;
            this.pos2 = pos2;
            this.pos3 = pos3;
        }
    }
    public class ToggleJson
    {
        private int pos1;
        private int pos2;

        public ToggleJson(int pos1, int pos2)
        {
            this.pos1 = pos1;
            this.pos2 = pos2;
        }
    }
    public class PotentJson
    {
        private int setting;

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
        public JoyDirSetting GetJoyDirSetting()
        {
            return new JoyDirSetting(joyJsonMap[leftJoyX], isLeftJoyXInverted ? 1 : 0);
        }
        public string ToJson()
        {
            JsonConfig json = new JsonConfig();
            return "";
        }
    }
}


