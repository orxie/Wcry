using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;

namespace DAL
{
   public  class UserServer
    {
        /// <summary>
        /// 数据库执行语句
        /// </summary>
        public static string sqltext = "";
        /// <summary>
        /// 登录操作
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static int UserLogin(UserInfo userinfo)
        {
            sqltext = "select COUNT(*) from [dbo].[UserInfo] where ID='" + userinfo.ID + "' and PassWord='" + userinfo.PassWord + "'";
            int i = (int)SQLHelper.ExecuteScalar(sqltext);
            return i;
        }
        /// <summary>
        /// 权限判断
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>

        public static int UserAuthority(UserInfo userinfo)
        {
            sqltext = "select P.PostID from dbo.UserInfo AS U,[dbo].[Post] AS P,[dbo].[Department] AS D where U.PostID=P.PostID AND P.DeptID=D.DeptID AND U.ID=" + userinfo.ID + "";
            int i = (int)SQLHelper.ExecuteScalar(sqltext);
            return i;
        }
       /// <summary>
       /// 查看请假信息
       /// </summary>
       /// <param name="ID"></param>
       /// <returns></returns>
        public static DataSet SelectAllMsg()
        {
            sqltext = "select [dbo].[Msg_type].[Tpname],[dbo].[Msg_info].[SubmitDay],[Msg_info].Cause,[dbo].[Msg_info].Stutas from [dbo].[Msg_info],[dbo].[Msg_type] where [dbo].[Msg_info].TpId=[dbo].[Msg_type].TpId and [UserId]='1015'  order by [dbo].[Msg_info].[Mid] desc";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            return ds;
        }
        
       /// <summary>
       /// 查找所有培训
       /// </summary>
       /// <param name="ID"></param>
       /// <returns></returns>
        public static DataSet SelectAllTrain()
        {
            sqltext = "select top(5) [Name],[Address],[Teacher],[Date],[TrainDetails],[phone] FROM [dbo].[Train] where [State]=3  order by [TrainId] desc";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            return ds;
        }
        
        /// <summary>
        /// 根据用户id查找用户信息
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static UserInfo SelectAllInfoByName(string id)
        {
            UserInfo User = new UserInfo();
            //查找指定用户
            sqltext = "select UserInfo.ID as 员工账号,UserInfo.Name as 员工姓名,UserInfo.Sex as 性别,UserInfo.PostID as 职位id,UserInfo.TelePhone as 手机号,UserInfo.Email as 电子邮箱,UserInfo.WorkDay as 入职日期,UserInfo.Education as 学历,UserInfo.Career as 专业,UserInfo.Birthday as 生日,UserInfo.IdCard as 身份证号,UserInfo.Marry as 婚姻情况,UserInfo.Status as 在职状态,UserInfo.BankAccount as 银行账号,UserInfo.Address as 地址,UserInfo.StartDay as 合同起始日期,UserInfo.Seniority as 工龄,Post.PostName as 职位名称,Department.DeptName as 部门名称 from UserInfo,Post,Department where ID='" + id + "' and UserInfo.PostID=Post.PostID and Post.DeptID=Department.DeptID";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                User.ID = dr["员工账号"].ToString();
                User.Name = dr["员工姓名"].ToString();
                User.Sex = dr["性别"].ToString();
                User.PostId = (int)dr["职位id"];
                User.TelePhone = dr["手机号"].ToString();
                User.Email = dr["电子邮箱"].ToString();
                User.WorkDay = dr["入职日期"].ToString();
                User.Education = dr["学历"].ToString();
                User.Career = dr["专业"].ToString();
                User.Birthday = dr["生日"].ToString();
                User.IdCard = dr["身份证号"].ToString();
                User.Marry = dr["婚姻情况"].ToString();
                User.BankAccount = dr["银行账号"].ToString();
                User.Status = (int)dr["在职状态"];
                User.Address = dr["地址"].ToString();
                User.StartDay = (DateTime)dr["合同起始日期"];
                User.Seniority = (int)dr["工龄"];
                User.Post = dr["职位名称"].ToString();
                User.Department = dr["部门名称"].ToString();
            }
            return User;
        }
        
        /// <summary>
        /// 查找banner图片信息
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static DataTable Selectbanner()
        {
            sqltext = "select top(4) [Banner_bg],[Banner_text],[Banner_text1] FROM [dbo].[banner]  order by [YM_id] desc";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;

        }
        /// <summary>
        /// 查找企业文化
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static DataTable Selectqywh()
        {
            sqltext = "select top(4) [Qywh],[Qywhxq] FROM [dbo].[qywh]  order by [Qywhid] desc";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;

        }
         /// <summary>
        /// 查找请假类别
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static DataTable SelecTqjType()
        {
            sqltext = "select TpId,Tpname from dbo.Msg_type";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }

       /// <summary>
       /// 查询所有部门列表
       /// </summary>
       /// <returns></returns>
        public static DataTable SelectBmleibie()
        {
            sqltext = "select DeptID,DeptName from dbo.Department";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }
       
      
        /// <summary>
        /// 提交请假单
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static int ADDQJ(Msg_info mag)
        {
            sqltext = "insert into [dbo].[Msg_info]([UserId],[TpId],[Cause],[Beginday],[EndDay],[SubmitDay],[Stutas])values('"+mag.UserId+"',"+mag.TpId+",'"+mag.Cause+"','"+mag.Beginday+"','"+mag.EndDay+"','"+mag.SubmitDay+"',"+mag.Stutas+")";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }
        /// <summary>
        /// 提交培训计划
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static int ADDpx(Train tr)
        {
            sqltext = "insert into [dbo].[Train]([Name],[Address],[Teacher],[Date],[State],[phone],[TrainDetails])values('"+tr.Name+"','"+tr.Address+"','"+tr.Teacher+"','"+tr.Date+"',"+tr.State+",'"+tr.phone+"','"+tr.TrainDetails+"')";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }
        /// <summary>
        /// 查看考勤
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static DataTable selectKq(string id)
        {
            sqltext = "select [dbo].[Attendance].Record,[dbo].[Attendance].AtUserID,[dbo].[AttendanceInfo].[Name],[dbo].[AttendanceInfo].Praise,[dbo].[AttendanceInfo].Punish  from [dbo].[Attendance],[dbo].[AttendanceInfo] where [dbo].[Attendance].AtId=[dbo].[AttendanceInfo].AtId and [dbo].[Attendance].UserID="+id+"";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }
   }
}
