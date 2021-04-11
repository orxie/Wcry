using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
  public  class qiandao
    {
        private int _userId;
        private DateTime _qdTime;
        private int _qdstate;

        public int UserId
        {
            get
            {
                return _userId;
            }

            set
            {
                _userId = value;
            }
        }

        public DateTime QdTime
        {
            get
            {
                return _qdTime;
            }

            set
            {
                _qdTime = value;
            }
        }

        public int Qdstate
        {
            get
            {
                return _qdstate;
            }

            set
            {
                _qdstate = value;
            }
        }
    }
}
