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
    public class ZDEMO2
    {
        Entities db;
        public ZDEMO2()
        {
            db = Entities.CreateEntities();
        }

        }
    }
