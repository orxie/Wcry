using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Department
    {
        private int _deptID;    //部门编号(主键)

        public int DeptID
        {
            get { return _deptID; }
            set { _deptID = value; }
        }
        private string _deptName; //部门名称

        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }
        private string _description;   //部门描述

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }
}
