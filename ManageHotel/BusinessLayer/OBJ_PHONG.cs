﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OBJ_PHONG
    {
        public int IDPHONG { get; set; }
        public string TENPHONG { get; set; }
        public bool? TRANGTHAI { get; set; }
        public double? DONGIA { get; set; }
        public int? IDLAU { get; set; }
        public int IDLOAIPHONG { get; set; }
        public string TENLAU { get; set; }
        public string TENLOAIPHONG { get; set; }
        public bool? DISABLED { get; set; }

    }
}
