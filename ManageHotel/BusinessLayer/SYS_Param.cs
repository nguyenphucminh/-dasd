using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BusinessLayer
{
    [Serializable]
    public class SYS_Param
    {
        string _macty;
        string _madvi;
        public string macty
        {
            get
            {
                return _macty;
            }
            set
            {
                _macty = value;
            }
        }   
        public string madvi
        {
            get
            {
                return _madvi;
            }
            set
            {
                _madvi = value;
            }
        }
        public SYS_Param(string macty,string madvi)
        {
            this.macty = macty;
            this.madvi = madvi;
        }
        public void SaveFile()
        {
            if (File.Exists("sysparam.ini"))
            {
                File.Delete("sysparam.ini");
            }    
            FileStream fs = File.Open("sysparam.ini", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

    }
}
