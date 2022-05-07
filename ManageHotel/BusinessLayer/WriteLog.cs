using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    [Serializable]
    public class WriteLog
    {
        public WriteLog()
        {

        }
        public void Fucntion_WriteLog(string user = "", string table = "", string action = "", string nameObjectAction = "")
        {
            string path = (AppDomain.CurrentDomain.BaseDirectory + "LogFile.txt");
            if (System.IO.File.Exists(path))
            {
                System.IO.File.AppendAllText(path, DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss tt") + "\t" + user + "\t" + table + "\t" + action + "\t" + nameObjectAction + Environment.NewLine);
            }
        }
    }
}
