using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class TrangThaiCBB
    {
        public string _display { set; get; }
        public bool _value { set; get; }

        public TrangThaiCBB()
        {

        }
        public TrangThaiCBB(bool _val, string _dis)
        {
            this._display = _dis;
            this._value = _val;
        }
        public static List<TrangThaiCBB> getList()
        {
            List<TrangThaiCBB> list = new List<TrangThaiCBB>();
            TrangThaiCBB[] collect = new TrangThaiCBB[2]
            {
                new TrangThaiCBB(false,"Chưa Hoàn Tất"),
                new TrangThaiCBB(true, "Đã Hoàn Tất")
            };
            list.AddRange(collect);
            return list;
        }
    }
}
