using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Attendance
    {
        private int _aDID;    //考勤表id（主键）

        public int ADID1
        {
            get { return _aDID; }
            set { _aDID = value; }
        }
        private int _atId;     //考勤编号（外键）

        public int AtId
        {
            get { return _atId; }
            set { _atId = value; }
        }
        private int _userId;     //用户id（外键）

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private DateTime _record;    //记录时间

        public DateTime Record
        {
            get { return _record; }
            set { _record = value; }
        }
        private int _atUserID;    //操作人id

        public int AtUserID
        {
            get { return _atUserID; }
            set { _atUserID = value; }
        }
    }
}
