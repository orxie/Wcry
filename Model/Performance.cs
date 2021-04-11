using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Performance
    {
        private int _perID; //绩效表id（主键）

        public int PerID
        {
            get { return _perID; }
            set { _perID = value; }
        }
        private int _userID; //用户id（外键)

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        private int _total;  //绩效总分

        public int Total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}
