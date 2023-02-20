using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;



namespace WindowsFormsApp3
{
    class Http
    {
        string URL = "localhost/";
        WebClient client;
        HttpServer Server;

        Http() {
            client = new WebClient();

        }

        string DownloadData(string link = "-1") {
            if (link == "-1") { link = URL; }
            byte[] myDataBuffer = client.DownloadData(URL);
            string download = Encoding.ASCII.GetString(myDataBuffer);
            return download;
        }


    }
}
