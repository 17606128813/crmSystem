using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Manage
{
    /// <summary>
    /// 省份表
    /// </summary>
    public class CityType
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 省份名称
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int CState { get; set; }
    }
}
