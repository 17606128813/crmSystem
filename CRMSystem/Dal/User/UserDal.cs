using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using System.Data.SqlClient;
using Dapper;


namespace Dal
{
    /// <summary>
    /// 用户相关dal
    /// </summary>
    public class UserDal
    {
        public string ConnStr = "Data Source=.;Initial Catalog=ECommerce;Integrated Security=True";

        /// <summary>
        /// 用户注册
        /// 一个手机号只能是一个用户
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int UserRegist(UserInfo userInfo)
        {
            int res = 0;
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                string sql = $@"
                INSERT INTO [ECommerce].[dbo].[UserInfo]
                           ([UserName]
                           ,[UserPass]
                           ,[Salt]
                           ,[NickName]
                           ,[UserImg]
                           ,[PhoneNumder]
                           ,[RealName]
                           ,[Province]
                           ,[City]
                           ,[Area]
                           ,[AddDetail]
                           ,[Email]
                           ,[UserMoney]
                           ,[UserType]
                           ,[Status]
                           ,[CreateTime]
                           ,[UpdateTime]
                           ,[CreaterId]
                           ,[UpdaterId])
                     VALUES
                           ('{userInfo.UserName}'
                           ,'{userInfo.UserPass}'
                           ,'{userInfo.Salt}'
                           ,'{userInfo.NickName}'
                           ,''
                           ,'{userInfo.PhoneNumder}'
                           ,'{userInfo.UserName}'
                           ,1
                           ,1
                           ,1
                           ,''
                           ,''
                           ,0
                           ,1
                           ,1
                           ,GETDATE()
                           ,GETDATE()
                           ,1
                           ,1);";

                res = connection.Execute(sql);
            }
            return res;
        }

        /// <summary>
        /// 判断手机号是否已存在
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public bool IsExistPhone(string phone)
        {
            using (IDbConnection connection = new SqlConnection(ConnStr))
            {
                string sql = $" select count(1) from UserInfo where PhoneNumder='{phone}' and status=1 ";
                return connection.ExecuteScalar<int>(sql) > 0;
            }
        }

    }
}
