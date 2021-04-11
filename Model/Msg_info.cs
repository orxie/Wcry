using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Msg_info
    {
        private int _mid;  //假条编号（主键）

        public int Mid
        {
            get { return _mid; }
            set { _mid = value; }
        }
        private string _userId;  //员工编号（外键）

        public string UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private int _tpId;        //类型ID （外键）

        public int TpId
        {
            get { return _tpId; }
            set { _tpId = value; }
        }
        private string _title;  //请假标题

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        private string _cause;     //请假原因

        public string Cause
        {
            get { return _cause; }
            set { _cause = value; }
        }
        private DateTime _beginday;  //开始日期

        public DateTime Beginday
        {
            get { return _beginday; }
            set { _beginday = value; }
        }
        private DateTime _endDay;    //结束日期

        public DateTime EndDay
        {
            get { return _endDay; }
            set { _endDay = value; }
        }
        private DateTime _submitDay;  //提交请假的日期

        public DateTime SubmitDay
        {
            get { return _submitDay; }
            set { _submitDay = value; }
        }
        private int _stutas;  //状态（0，未审核1，通过2，未通过）

        public int Stutas
        {
            get { return _stutas; }
            set { _stutas = value; }
        }
        private int _msgrId;  //审批人编号（外键）0

        public int MsgrId
        {
            get { return _msgrId; }
            set { _msgrId = value; }
        }
    }
}
