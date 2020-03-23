using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient
{
    /// <summary>
    /// 添加用户的请求
    /// 2020-03-10 此处当作注册案例
    /// </summary>
    public class UserAddRequest:BaseRequest
    {
        /// <summary>
        /// 这里的用户名
        /// 其实就是手机号
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Pwd { get; set; }

        public override string GetApiName()
        {
            return "/api/User/AddUser";
        }
    }
}
