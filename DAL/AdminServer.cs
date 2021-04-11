using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data;

namespace DAL
{
   public class AdminServer
    {

        /// <summary>
        /// 数据库执行语句
        /// </summary>
        public static string sqltext = "";
        /// <summary>
        /// 查找所有用户信息
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static DataTable SelectAllInfo()
        {
            sqltext = "select [dbo].[UserInfo].[Name], [dbo].[UserInfo].ID, [dbo].[UserInfo].Sex, [dbo].[UserInfo].Career, [dbo].[UserInfo].Education, [dbo].[Post].PostName,[dbo].[Department].DeptName,[dbo].[UserInfo].Seniority,[dbo].[UserInfo].[Address],[dbo].[UserInfo].[Status],[dbo].[UserInfo].TelePhone,[dbo].[UserInfo].IdCard,[dbo].[UserInfo].Birthday,[dbo].[UserInfo].Email,[dbo].[UserInfo].WorkDay from[dbo].[Department],[dbo].[UserInfo],[dbo].[Post] where [dbo].[UserInfo].[PostID]=[dbo].[Post].PostID and [dbo].[Post].DeptID=[dbo].[Department].DeptID";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
             
            return dt;
        }

        //注意：测试数据
        public static DataTable SelectAllInfobyshu(int a)
        {
            sqltext = "select top("+a+") [dbo].[UserInfo].[Name], [dbo].[UserInfo].ID, [dbo].[UserInfo].Sex, [dbo].[UserInfo].Career, [dbo].[UserInfo].Education, [dbo].[Post].PostName,[dbo].[Department].DeptName,[dbo].[UserInfo].Seniority,[dbo].[UserInfo].[Address],[dbo].[UserInfo].[Status],[dbo].[UserInfo].TelePhone,[dbo].[UserInfo].IdCard,[dbo].[UserInfo].Birthday,[dbo].[UserInfo].Email,[dbo].[UserInfo].WorkDay from[dbo].[Department],[dbo].[UserInfo],[dbo].[Post] where [dbo].[UserInfo].[PostID]=[dbo].[Post].PostID and [dbo].[Post].DeptID=[dbo].[Department].DeptID";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectMhcx(UserInfo user)
        {
            sqltext = "select [dbo].[UserInfo].[Name], [dbo].[UserInfo].ID, [dbo].[UserInfo].Sex, [dbo].[UserInfo].Career, [dbo].[UserInfo].Education, [dbo].[Post].PostName,[dbo].[Department].DeptName,[dbo].[UserInfo].Seniority,[dbo].[UserInfo].[Address],[dbo].[UserInfo].[Status],[dbo].[UserInfo].TelePhone,[dbo].[UserInfo].IdCard,[dbo].[UserInfo].Birthday,[dbo].[UserInfo].Email,[dbo].[UserInfo].WorkDay from[dbo].[Department],[dbo].[UserInfo],[dbo].[Post] where [dbo].[UserInfo].[PostID]=[dbo].[Post].PostID and [dbo].[Post].DeptID=[dbo].[Department].DeptID and [dbo].[UserInfo].[Name] like '%" + user.Name+ "%' and [dbo].[UserInfo].ID like '%"+user.ID+"%' and [dbo].[UserInfo].IdCard like '%"+user.IdCard+"%' and  [dbo].[UserInfo].TelePhone like '%"+user.TelePhone+"%' and [dbo].[Department].DeptName like '%"+user.Department+"%'";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            return dt;
        }

        /// <summary>
        /// 查看职位类别
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static DataTable SelecZWType()
        {
            sqltext = "select [PostID],[PostName] from [dbo].[Post]";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }
        /// <summary>
        /// 查看部门类别
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static DataTable SelecBMType()
        {
            sqltext = "select [DeptID],[DeptName]from [dbo].[Department]";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }

       /// <summary>
       /// 添加员工
       /// </summary>
       /// <param name="userinfo"></param>
       /// <returns></returns>
        public static int AddUser(UserInfo userinfo)
        {
            sqltext = "insert into dbo.UserInfo(Name,Sex,PostID,TelePhone,Email,WorkDay,Education,Career,Birthday,IdCard,Marry,Status,Address,StartDay,Seniority,PassWord,ID,BankAccount)values('" + userinfo.Name + "','" + userinfo.Sex + "','" + userinfo.PostId + "','" + userinfo.TelePhone + "','" + userinfo.Email + "','" + userinfo.WorkDay + "','" + userinfo.Education + "','" + userinfo.Career + "','" + userinfo.Birthday + "','" + userinfo.IdCard + "','" + userinfo.Marry + "','" + userinfo.Status + "','" + userinfo.Address + "','" + userinfo.StartDay + "','" + userinfo.Seniority + "','"+userinfo.PassWord+"','" + userinfo.ID + "','" + userinfo.BankAccount + "')";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }

        /// <summary>
       /// 添加考勤类型
       /// </summary>
       /// <param name="userinfo"></param>
       /// <returns></returns>
        public static int addATTTYPE(AttendanceInfo att)
        {
            sqltext = "insert [dbo].[AttendanceInfo]([Name],[Introduce],[Praise],[Punish])values('" + att.Name + "','" + att.Introduce + "'," + att.Praise + "," + att.Punish+ ")";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }
       /// <summary>
       /// 添加考勤
       /// </summary>
       /// <param name="userinfo"></param>
       /// <returns></returns>
        public static int Addat(Attendance att)
        {
            sqltext = "insert into [dbo].[Attendance]([AtId],[UserId],[Record],[AtUserID]) values (" + att.AtId + "," + att.UserId + ",'"+att.Record+"'," + att.AtUserID + ")";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        
        }


        /// <summary>
       /// 添加广告
       /// </summary>
       /// <param name="userinfo"></param>
       /// <returns></returns>
        public static int AddBanner(banner bann)
        {
            sqltext = "insert into [dbo].[banner]([Banner_bg],[Banner_text],[Banner_text1]) values ('"+bann.Banner_bg+"','"+bann.Banner_text+"','"+bann.Banner_text1+"')";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }
        /// <summary>
       /// 添加企业文化
       /// </summary>
       /// <param name="userinfo"></param>
       /// <returns></returns>
        public static int Addqywh(qy qywh)
        {
            sqltext = "insert into [dbo].[qywh]([Qywh],[Qywhxq]) values ('"+qywh.Qywh+"','"+qywh.Qywhxq+"')";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }

        /// <summary>
        /// 根据id查找类别
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static AttendanceInfo SelectattInfoByid(string id)
        {
            AttendanceInfo att = new AttendanceInfo();
            sqltext = "select * from[dbo].[AttendanceInfo] where [AtId]=1";
              DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                att.Name = dr["Name"].ToString();
                att.Introduce = dr["Introduce"].ToString();
                att.Praise = Convert.ToInt32( dr["Praise"]);
                att.Punish = Convert.ToInt32(dr["Punish"]);
            }
            return att;
        }
        /// <summary>
        /// 根据用户id查找用户信息
        /// </summary>
        /// <param name="US"></param>
        /// <returns></returns>
        public static UserInfo SelectUserInfoByid(string id)
        {
            UserInfo User = new UserInfo();
            //查找指定用户
            sqltext = "select [PassWord],[BankAccount],[Marry],[PostID],[Name],ID, Sex, Career, Education,Seniority,[Address],[Status],TelePhone,IdCard,Birthday,Email,WorkDay from[dbo].[UserInfo]where [dbo].[UserInfo].ID=" + id + "";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);

            DataTable dt = new DataTable();
            dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                User.PassWord = dr["PassWord"].ToString();
                User.ID = dr["ID"].ToString();
                User.Name = dr["Name"].ToString();
                User.Sex = dr["Sex"].ToString();
                User.PostId = (int)dr["PostID"];
                User.TelePhone = dr["TelePhone"].ToString();
                User.Email = dr["Email"].ToString();
                User.WorkDay = dr["WorkDay"].ToString();
                User.Education = dr["Education"].ToString();
                User.Career = dr["Career"].ToString();
                User.Birthday = dr["Birthday"].ToString();
                User.IdCard = dr["IdCard"].ToString();
                User.Marry = dr["Marry"].ToString();
                User.BankAccount = dr["BankAccount"].ToString();
                User.Address = dr["Address"].ToString();
                User.StartDay = (DateTime)dr["WorkDay"];
            }
            return User;
        }
        /// <summary>
        /// 修改员工信息操作
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static int Updata(UserInfo userinfo)
        {
            sqltext = "update UserInfo set Name='" + userinfo.Name + "',Sex='" + userinfo.Sex + "',TelePhone='" + userinfo.TelePhone + "',Email='" + userinfo.Email + "',WorkDay='" + userinfo.WorkDay + "',Education='" + userinfo.Education + "',Career='" + userinfo.Career + "',Birthday='" + userinfo.Birthday + "',IdCard='" + userinfo.IdCard + "',Marry='" + userinfo.Marry + "',BankAccount='" + userinfo.BankAccount + "',Address='" + userinfo.Address + "',StartDay='" + userinfo.StartDay + "',Seniority='" + userinfo.Seniority + "',PassWord='" + userinfo.PassWord + "' where ID='" + userinfo.ID + "'";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }
        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public static int daleteUser(string id)
        {

            sqltext = "delete from UserInfo where ID='" + id + "'";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }

       /// <summary>
       /// 根据id修改密码
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public static int updatePassByID(UserInfo user)
        {
            sqltext = "update UserInfo set[PassWord]='"+user.PassWord+"'  where ID='" + user.ID+ "'";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }
        /// <summary>
        /// 根据id修改考勤类型
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int upatttapyByID(AttendanceInfo att)
        {
            sqltext = "update [dbo].[AttendanceInfo] set[Name]='"+att.Name+"',[Introduce]='"+att.Introduce+"',[Praise]="+att.Praise+",[Punish]="+att.Punish+" where [AtId]="+att.AtId+"";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }
       /// <summary>
       /// 根据id修改状态
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
        public static int updateStateByid(Train  train)
        {
            sqltext = "update [dbo].[Train] set [State]=" + train.State+ " where [TrainId]=" + train.TrainId + "";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }
        /// <summary>
        /// 查看所有员工培训申请
        /// </summary>
        /// <returns></returns>
        public static DataTable SelectAllTrain()
        {
            sqltext = "select [TrainId],Name,Address,Date,Teacher,TrainDetails,phone,State from dbo.Train where [State]=0";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }
       /// <summary>
       /// 查看所有培训申请表
       /// </summary>
       /// <returns></returns>
        public static DataTable SelectAllAttendance()
        {
            sqltext = "select UserInfo.Name as 姓名,AttendanceInfo.Name as 考勤名称,AttendanceInfo.Introduce,AttendanceInfo.Praise,AttendanceInfo.Punish from UserInfo,AttendanceInfo,Attendance where UserInfo.UserId=Attendance.UserId and Attendance.AtId=AttendanceInfo.AtId";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }

        public static DataTable SelectAllMsg()
        {
            sqltext = "select UserInfo.ID,UserInfo.Name,Msg_info.Cause,Msg_info.Beginday,Msg_info.EndDay,Msg_info.SubmitDay,Msg_type.Tpname,Msg_type.TpDescrib from UserInfo,Msg_info,Msg_type where UserInfo.ID=Msg_info.UserId and Msg_info.TpId=Msg_type.TpId and [dbo].[Msg_info].Stutas=0";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }

        public static DataTable SelectAllPerformance()
        {
            sqltext = "select UserInfo.Name,Performance.Total,Salary.Bonus,Salary.Forfeit,Salary.Money,Salary.Dough,Salary.State,Salary.Time from UserInfo,Salary,Performance where UserInfo.UserId=Performance.UserId and UserInfo.UserId=Salary.UserId";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }

        public static DataTable SelectqjTYPE()
        {
            sqltext = "select [AtId],[Name],[Introduce],[Praise],[Punish] from [dbo].[AttendanceInfo]";
            DataSet ds = new DataSet();
            ds = SQLHelper.ExecuteDataSet(sqltext);
            DataTable dt = new DataTable();
            dt = ds.Tables[0];

            return dt;
        }
        /// <summary>
        /// 根据id修改请假状态
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int updateStateqjByid(Msg_info ms)
        {
            sqltext = "update [dbo].[Msg_info] set [Stutas]=" + ms.Stutas+ " where [UserId]="+ms.UserId+"";
            int i = (int)SQLHelper.ExecuteNonQuery(sqltext);
            return i;
        }

    }
}
