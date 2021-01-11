using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorPhotoApp
{
    static class Log
    {
        static RichTextBox Logger { get; set; }

        public static void InitLogger(RichTextBox logTextBox)
        {
         Logger = logTextBox;
        }
       
        static public void AddToLog(string msg) => Logger.Text += $"{msg} {DateTime.UtcNow.ToLongTimeString()}\n";
    }
}
