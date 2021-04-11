using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;
using System.Data;


namespace BLL
{
   public  class UserManager
    {
        /// <summary>
        /// 登录操作
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static int UserLogin(UserInfo userinfo)
        {
            return DAL.UserServer.UserLogin(userinfo);
        }
        /// <summary>
        /// 权限判断
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static int UserAuthority(UserInfo userinfo)
        {
            return DAL.UserServer.UserAuthority(userinfo);
        }
       /// <summary>
       /// 查找所有培训
       /// </summary>
       /// <param name="ID"></param>
       /// <returns></returns>
        public static DataSet SelectAllTrain()
        {
            return DAL.UserServer.SelectAllTrain();
        }
       /// <summary>
        /// 根据用户id查找用户信息
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static UserInfo SelectAllInfoByName(string id)
        {
            return DAL.UserServer.SelectAllInfoByName(id);
        }
        /// <summary>
        /// 查找banner图片信息
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static DataTable Selectbanner()
        {
            return DAL.UserServer.Selectbanner();
        }
         /// <summary>
        /// 查找企业文化
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static DataTable Selectqywh()
        {
            return DAL.UserServer.Selectqywh();
        }
        /// <summary>
        /// 查找请假类别
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static DataTable SelecTqjType()
        {
            return DAL.UserServer.SelecTqjType();
        }
        /// <summary>
        /// 提交请假单
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static int ADDQJ(Msg_info mag)
        {
            return DAL.UserServer.ADDQJ(mag);
        }
        /// <summary>
        /// 提交培训计划
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static int ADDpx(Train tr)
        {
            return DAL.UserServer.ADDpx(tr);
        }
       /// <summary>
       /// 查看请假信息
       /// </summary>
       /// <param name="ID"></param>
       /// <returns></returns>
        public static DataSet SelectAllMsg()
        {
            return DAL.UserServer.SelectAllMsg();
        }
        /// <summary>
        /// 查看考勤
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static DataTable selectKq(string id)
        {
            return DAL.UserServer.selectKq(id);
        }

        /// <summary>
       /// 查询所有部门列表
       /// </summary>
       /// <returns></returns>
        public static DataTable SelectBmleibie()
        {
            return DAL.UserServer.SelectBmleibie();
        }
    }
}
