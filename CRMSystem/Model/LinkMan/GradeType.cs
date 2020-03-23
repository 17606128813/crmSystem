using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.LinkMan
{
    /// <summary>
    /// 等级表
    /// </summary>
    public class GradeType
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int GId { get; set; }
        /// <summary>
        /// 等级名称
        /// </summary>
        public string GName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int GState { get; set; }
    }
}
