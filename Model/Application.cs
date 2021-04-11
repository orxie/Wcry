using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Application
    {
        private int _appID;      // 职位申请id（主键）

        public int AppID
        {
            get { return _appID; }
            set { _appID = value; }
        }
        private int _userID;  //员工编号（外键）

        public int UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
        private int _apPostId; //申请职位id

        public int ApPostId
        {
            get { return _apPostId; }
            set { _apPostId = value; }
        }
        private int _apDepartmentId; //申请部门id

        public int ApDepartmentId
        {
            get { return _apDepartmentId; }
            set { _apDepartmentId = value; }
        }
        private string _exchange;  //调换原因

        public string Exchange
        {
            get { return _exchange; }
            set { _exchange = value; }
        }
        private DateTime _date;   //提交时间

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        private int _hrstate;  //审批状态（0未审批，1通过，2未通过）

        public int Hrstate
        {
            get { return _hrstate; }
            set { _hrstate = value; }
        }
        private int _state;       //审批人ID

        public int State
        {
            get { return _state; }
            set { _state = value; }
        }
    }
}
