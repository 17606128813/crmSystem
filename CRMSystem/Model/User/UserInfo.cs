using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    ///  用户的实体
    /// </summary>
    public class UserInfo
    {
        /// <summary>
        /// 昵称
        /// </summary>
        public string NickName { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string PhoneNumder { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string UserPass { get; set; }

        /// <summary>
        /// 密码的盐
        /// </summary>
        public string Salt { get; set; }
    }
}
