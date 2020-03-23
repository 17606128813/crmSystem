using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Manage
{
    /// <summary>
    /// 机构级别表
    /// </summary>
    public class RankType
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int RId { get; set; }
        /// <summary>
        /// 级别名称
        /// </summary>
        public string RName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int RState { get; set; }
    }
}
