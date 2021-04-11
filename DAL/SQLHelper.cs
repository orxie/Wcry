using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;

namespace DAL
{
   public class SQLHelper
    {
        /// <summary>
        /// 连接数据库的链接字符串
        /// </summary>
        public static readonly string Configuration = ConfigurationManager.ConnectionStrings["MySql"].ConnectionString;

        /// <summary>
        /// 获取首行首列数据的代码
        /// </summary>
        /// <param name="sqltext"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sqltext)
        {
            using (SqlConnection conn = new SqlConnection(Configuration))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(sqltext, conn);
                object val = com.ExecuteScalar();
                return val;
            }
        }
        /// <summary>
        /// 返回受影响的行数
        /// </summary>
        /// <param name="sqltext"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sqltext)
        {
            using (SqlConnection conn = new SqlConnection(Configuration))
            {
                conn.Open();
                SqlCommand com = new SqlCommand(sqltext, conn);
                int i = com.ExecuteNonQuery();
                return i;
            }
        }
        /// <summary>
        /// 返回DataSet结果集查询
        /// </summary>
        /// <param name="sqltext">要执行的sql语句</param>
        /// <returns>返回DataSet数据类型</returns>
        public static DataSet ExecuteDataSet(string sqltext)
        {
            using (SqlConnection conn = new SqlConnection(Configuration))
            {
                conn.Open();
                //适配器
                SqlDataAdapter sqlda = new SqlDataAdapter(sqltext, conn);
                DataSet ds = new DataSet();
                sqlda.Fill(ds);
                return ds;
            }
        }

    }
}
