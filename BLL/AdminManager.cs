using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.Sql;
using System.Data;

namespace BLL
{
   public class AdminManager
    { 
        /// <summary>
        /// 查找所有用户信息
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
       public static DataTable SelectAllInfo()
       {
         return  DAL.AdminServer.SelectAllInfo();
       }
        //注意  测试数据
        public static DataTable  SelectAllInfobyshu(int a)
        {
            return DAL.AdminServer.SelectAllInfobyshu(a);
        }
       
         /// <summary>
         /// 查看部门类别
         /// </summary>
         /// <param name="US"></param>
         /// <returns></returns>
        public static DataTable SelecBMType()
       {
           return DAL.AdminServer.SelecBMType();
       }
        /// <summary>
       /// 添加广告
       /// </summary>
       /// <param name="userinfo"></param>
       /// <returns></returns>
       public static int AddBanner(banner bann)
       {
           return DAL.AdminServer.AddBanner(bann);
       }
         /// <summary>
       /// 添加企业文化
       /// </summary>
       /// <param name="userinfo"></param>
       /// <returns></returns>
       public static int Addqywh(qy qywh)
       {
           return DAL.AdminServer.Addqywh(qywh);
       }

        /// <summary>
        /// 查看职位类别
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
       public static DataTable SelecZWType()
       {
           return DAL.AdminServer.SelecZWType();
       }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <returns></returns>
       public static DataTable SelectMhcx(UserInfo user)
       {
           return DAL.AdminServer.SelectMhcx(user);
       }
          /// <summary>
       /// 添加员工
       /// </summary>
       /// <param name="userinfo"></param>
       /// <returns></returns>
       public static int AddUser(UserInfo userinfo)
       {
           return DAL.AdminServer.AddUser(userinfo);
       }
         /// <summary>
       /// 添加考勤类型
       /// </summary>
       /// <param name="userinfo"></param>
       /// <returns></returns>
       public static int addATTTYPE(AttendanceInfo att)
       {
           return DAL.AdminServer.addATTTYPE(att);
       }
          /// <summary>
        /// 根据用户id查找用户信息
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
       public static UserInfo SelectUserInfoByid(string id)
       {
           return DAL.AdminServer.SelectUserInfoByid(id);
       }
        /// <summary>
        /// 修改操作
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
       public static int UpdataUser(UserInfo userinfo)
       {
           return DAL.AdminServer.Updata(userinfo);
       }
         /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
       public static int daleteUser(string id)
       {
           return DAL.AdminServer.daleteUser(id);
       }
        /// <summary>
       /// 根据id修改密码
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public static int updatePassByID(UserInfo user)
       {
           return DAL.AdminServer.updatePassByID(user);
       }
          /// <summary>
        /// 查看所有员工培训申请
        /// </summary>
        /// <returns></returns>
       public static DataTable SelectAllTrain()
       {
           return DAL.AdminServer.SelectAllTrain();
       }

       /// <summary>
       /// 根据id修改状态
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       public static int updateStateByid(Train train)
       {
           return DAL.AdminServer.updateStateByid(train);
       }
       /// <summary>
       /// 查看所有培训申请表
       /// </summary>
       /// <returns></returns>
       public static DataTable SelectAllAttendance()
       {
           return DAL.AdminServer.SelectAllAttendance();
       }

       public static DataTable SelectAllMsg()
       {
           return DAL.AdminServer.SelectAllMsg();
       }


       public static DataTable SelectAllPerformance()
       {
           return DAL.AdminServer.SelectAllPerformance();
       }

          /// <summary>
       /// 添加考勤
       /// </summary>
       /// <param name="userinfo"></param>
       /// <returns></returns>
       public static int Addat(Attendance att)
       {
           return DAL.AdminServer.Addat(att);
       }
       /// <summary>
        /// 根据id修改请假状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public static int updateStateqjByid(Msg_info ms)
       {
           return DAL.AdminServer.updateStateqjByid(ms);
       }
       public static DataTable SelectqjTYPE()
       {
           return DAL.AdminServer.SelectqjTYPE();
       }
        /// <summary>
        /// 根据id查找类别
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
       public static AttendanceInfo SelectattInfoByid(string id)
       {
           return DAL.AdminServer.SelectattInfoByid(id);
       }
         /// <summary>
        /// 根据id修改考勤类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
       public static int upatttapyByID(AttendanceInfo att)
       {
           return DAL.AdminServer.upatttapyByID(att);
       }
    }
}
