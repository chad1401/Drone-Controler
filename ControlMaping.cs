using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;



namespace WindowsFormsApp3
{
    public class ControlMaping
    {
        public int controlMode { get; set; }
        public string leftJoy { get; set; }
        public bool isLeftJoyInverted { get; set; }
        public string rightJoy { get; set; }
        public bool isRightJoyInverted { get; set; }
        public string pot1 { get; set; }
        public string pot2 { get; set; }
        public string triSwitch1 { get; set; }
        public string triSwitch2 { get; set; }
        public string toggleSwitch1 { get; set; }
        public string toggleSwitch2 { get; set; }
    }


    public class Http //simple shell class for sending and receving data
    {
        public string URI;
        WebClient client;

        public Http()
        {
            client = new WebClient();
        }

        public void PostData(string msg)
        {
            Uri myUri = new Uri(URI);
            Stream postStream = client.OpenWrite(URI);
            postStream.Write(Encoding.ASCII.GetBytes(msg), 0, msg.Length);
            postStream.Close();
        }

        public string DownloadData()
        {
            byte[] myDataBuffer = client.DownloadData(URI);
            string download = Encoding.ASCII.GetString(myDataBuffer);
            return download;
        }
    }
}


