using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OBJ_DATPHONG
    {
        public int IDDP { get; set; }
        public int IDKHACH { get; set; }
        public string NAMEKHACH { get; set; }
        public DateTime? NGAYDAT { get; set; }
        public DateTime? NGAYTRA { get; set; }
        public double? SOTIEN { get; set; }
        public int? SONGUOI { get; set; }
        public int IDUSER { get; set; }
        public string MACTY { get; set; }
        public string MADVI { get; set; }
        public bool? TRANGTHAI { get; set; }
        public bool? DOAN { get; set; }
        public string GHICHU { get; set; }
        public bool? DISABLED { get; set; }


        //public string TENPHONG { get; set; }
        //public int DONGIA { get; set; }
        //public int IDLAU { get; set; }
        //public string TENLAU { get; set; }
        //public int IDLOAIPHONG { get; set; }
        //public string TENLOAIPHONG { get; set; }
    }
}
