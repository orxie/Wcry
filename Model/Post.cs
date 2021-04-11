using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class Post
    {
        private int _postID;  //职位编号（主键）

        public int PostID
        {
            get { return _postID; }
            set { _postID = value; }
        }
        private string _postName;  //职位名称

        public string PostName
        {
            get { return _postName; }
            set { _postName = value; }
        }
        private int _postLevel;   //职位级别

        public int PostLevel
        {
            get { return _postLevel; }
            set { _postLevel = value; }
        }
        private int _deptID;  //部门编号(外键)

        public int DeptID
        {
            get { return _deptID; }
            set { _deptID = value; }
        }
        private string _postDuty;    //职位职责

        public string PostDuty
        {
            get { return _postDuty; }
            set { _postDuty = value; }
        }
    }
}
