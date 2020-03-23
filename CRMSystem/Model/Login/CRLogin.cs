using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Login
{
    /// <summary>
    /// 登录表
    /// </summary>
    public class CRLogin
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 用户密码
        /// </summary>
        public string CPwd { get; set; }
        /// <summary>
        /// 盐
        /// </summary>
        public string CSalt { get; set; }
        /// <summary>
        /// 最后登录时间
        /// </summary>
        public DateTime CLastTime { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建人id
        /// </summary>
        public int CreatorId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime CUpdateTime { get; set; }
        /// <summary>
        /// 修改人id
        /// </summary>
        public int UpdatorId { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int CState { get; set; }
    }
}
