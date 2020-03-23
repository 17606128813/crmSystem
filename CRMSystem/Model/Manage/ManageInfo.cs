using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Manage
{
    /// <summary>
    /// 机构信息管理表
    /// </summary>
    public class ManageInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int MId { get; set; }
        /// <summary>
        /// 机构名称
        /// </summary>
        public string MName { get; set; }
        /// <summary>
        /// 机构级别
        /// </summary>
        public int MRank { get; set; }
        /// <summary>
        /// 省份/市
        /// </summary>
        public int MCity { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string MAgent { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string MLink { get; set; }
        /// <summary>
        /// 审核状态
        /// </summary>
        public bool MAState { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int MState { get; set; }
    }
}
