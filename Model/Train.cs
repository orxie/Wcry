using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Train
    {
        private int _trainId;  //培训编号（主键）

        public int TrainId
        {
            get { return _trainId; }
            set { _trainId = value; }
        }
        private string _name;    //培训名称

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _address;  //培训地点

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _teacher; //培训教师

        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }
        private DateTime _date;  //培训时间

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        private int _state; //培训报名审批人审批状态（0未审批，1通过，2未通过，3发布）

        public int State
        {
            get { return _state; }
            set { _state = value; }
        }
        private string _trainDetails;    //培训详情

        public string TrainDetails
        {
            get { return _trainDetails; }
            set { _trainDetails = value; }
        }
        private string _phone;

        public string phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }
}
