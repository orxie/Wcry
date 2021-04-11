using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Contract
    {
        private int _contractId; //合同id(主键)

        public int ContractId
        {
            get { return _contractId; }
            set { _contractId = value; }
        }
        private int _userId; // 员工编号（外键）

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        private string _contractName; //合同名称

        public string ContractName
        {
            get { return _contractName; }
            set { _contractName = value; }
        }
        private string _contracInfo; //合同内容

        public string ContracInfo
        {
            get { return _contracInfo; }
            set { _contracInfo = value; }
        }
        private DateTime _startTime; //合同起始时间

        public DateTime StartTime
        {
            get { return _startTime; }
            set { _startTime = value; }
        }
        private DateTime _endTime; //合同到期时间

        public DateTime EndTime
        {
            get { return _endTime; }
            set { _endTime = value; }
        }
    }
}
