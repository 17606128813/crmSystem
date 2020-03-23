using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.LinkMan
{
    /// <summary>
    /// 联系人信息表
    /// </summary>
    public class LinkManInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int LId { get; set; }
        /// <summary>
        /// 机构名称
        /// </summary>
        public string LManage { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string LName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool LSex { get; set; }
        /// <summary>
        /// 职务
        /// </summary>
        public int LDuty { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public int LPhone { get; set; }
        /// <summary>
        /// 办公电话
        /// </summary>
        public string LTelephone { get; set; }
        /// <summary>
        /// 重要等级
        /// </summary>
        public int LGrade { get; set; }
        /// <summary>
        /// 跟进状态
        /// </summary>
        public int LFState { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int LState { get; set; }
    }
}
