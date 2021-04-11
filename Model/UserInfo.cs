using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class UserInfo //员工编号（主键）
    {
        private string _iD;

        public string ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _name;//员工姓名

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _sex; //员工性别

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }
        private int _postID; //职位id（外键）

        public int PostId
        {
            get { return _postID; }
            set { _postID = value; }
        }

        private string _post; //职位

        public string Post
        {
            get { return _post; }
            set { _post = value; }
        }
        private string  _department; //部门

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        private string _telePhone; //手机号

        public string TelePhone
        {
            get { return _telePhone; }
            set { _telePhone = value; }
        }
        private string _email;  //邮件

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _workDay;    //入职日期

        public string WorkDay
        {
            get { return _workDay; }
            set { _workDay = value; }
        }
        private string _education;   //学历

        public string Education
        {
            get { return _education; }
            set { _education = value; }
        }
        private string _career;   //专业

        public string Career
        {
            get { return _career; }
            set { _career = value; }
        }
        private string _birthday;  //生日

        public string Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        private string _idCard;   //身份证号

        public string IdCard
        {
            get { return _idCard; }
            set { _idCard = value; }
        }
        private string _marry;    //婚姻情况

        public string Marry
        {
            get { return _marry; }
            set { _marry = value; }
        }
        private string _birthplace;   //籍贯

        public string Birthplace
        {
            get { return _birthplace; }
            set { _birthplace = value; }
        }
        private string _bankAccount;   //银行账号

        public string BankAccount
        {
            get { return _bankAccount; }
            set { _bankAccount = value; }
        }
        private int _status;      //在职状态（0在职，1离职，2退休）

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }
        private string _leaveDay;   //离职日期

        public string LeaveDay
        {
            get { return _leaveDay; }
            set { _leaveDay = value; }
        }
        private string _address;     //地址

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _userPicURL;   //图片地址

        public string UserPicURL
        {
            get { return _userPicURL; }
            set { _userPicURL = value; }
        }
        private DateTime _startDay;   //合同起始日期

        public DateTime StartDay
        {
            get { return _startDay; }
            set { _startDay = value; }
        }
        private int _seniority;   //工龄

        public int Seniority
        {
            get { return _seniority; }
            set { _seniority = value; }
        }
        private string _passWord; //密码

        public string PassWord
        {
            get { return _passWord; }
            set { _passWord = value; }
        }
     }
}
