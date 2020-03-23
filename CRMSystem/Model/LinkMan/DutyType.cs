using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.LinkMan
{
    /// <summary>
    /// 职务表
    /// </summary>
    public class DutyType
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int DId { get; set; }
        /// <summary>
        /// 职务名称
        /// </summary>
        public string DName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int DState { get; set; }
    }
}
