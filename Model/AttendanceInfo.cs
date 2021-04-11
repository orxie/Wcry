using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class AttendanceInfo
    {
        private int _atId; //考勤编号（主键）

        public int AtId
        {
            get { return _atId; }
            set { _atId = value; }
        }
        private string _name;  //考勤名称

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _introduce; //类型介绍

        public string Introduce
        {
            get { return _introduce; }
            set { _introduce = value; }
        }
        private int _praise;    //奖励分数

        public int Praise
        {
            get { return _praise; }
            set { _praise = value; }
        }
        private int _punish;      //惩罚分数

        public int Punish
        {
            get { return _punish; }
            set { _punish = value; }
        }
    }
}
