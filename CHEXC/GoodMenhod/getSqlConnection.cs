using System;
using System.Collections.Generic;
using System.Text;

using System.Data.SqlClient;
namespace CHEXC.GoodMenhod
{
   public class getSqlConnection
    {
        #region   代码中用到的变量
        string G_Str_ConnectionString = "Data Source=DESKTOP-2I082FH\\SQLEXPRESS;Initial Catalog=Super;Integrated Security=SSPI;";
        SqlConnection G_Con;  //声明链接对象
        #endregion

        #region  构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
       public getSqlConnection()
        {
            
        }
        #endregion

        #region   连接数据库
        /// <summary>
        /// 连接数据库
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetCon()
        {
            G_Con = new SqlConnection(G_Str_ConnectionString);
            G_Con.Open();
            return G_Con;
        }
        #endregion
    }
}
