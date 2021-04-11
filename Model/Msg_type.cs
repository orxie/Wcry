using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Msg_type
    {
        private int _tpId; //类型ID （主键）

        public int TpId
        {
            get { return _tpId; }
            set { _tpId = value; }
        }
        private string _tpname;   //类型名称

        public string Tpname
        {
            get { return _tpname; }
            set { _tpname = value; }
        }
        private string _tpDescrib;  //类型描述

        public string TpDescrib
        {
            get { return _tpDescrib; }
            set { _tpDescrib = value; }
        }
    }
}
