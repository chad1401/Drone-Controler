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
        public string xGim1 { get; set; }
        public string yGim1 { get; set; }
        public string xGim2 { get; set; }
        public string yGim2 { get; set; }
        public string pot1 { get; set; }
        public string pot2 { get; set; }
        public string bi_sw1 { get; set; }
        public string bi_sw2 { get; set; }
        public string tri_sw1 { get; set; }
        public string tri_sw2 { get; set; }
        public string but1 { get; set; }
        public string but2 { get; set; }


    }

    public class Http
    {
        public string URI;
        private static readonly HttpClient client = new HttpClient();

        public Http()
        {
        }

        async public void PostData(string msg)
        {

            var values = new Dictionary<string, string>
            {
                { "JSON", msg }
            };

            var content = new StringContent(msg, Encoding.UTF8, "application/json");

            try { var response = await client.PostAsync(URI, content); } catch(Exception e) { }
        }
    }


    public class HttpLegasy //simple shell class for sending and receving data
    {
        WebClient client;


        public string URI;
        UriBuilder builder;



        public HttpLegasy()
        {
            client = new WebClient();
        }

        public void PostData(string msg)
        {

            builder = new UriBuilder(URI);

            Uri myUri = builder.Uri;
            Stream postStream = client.OpenWrite(myUri);

            postStream.Write(Encoding.ASCII.GetBytes(msg), 0, msg.Length);
            // Close the stream and release resources.
            postStream.Close();

        }
    }
}


