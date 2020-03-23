using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.LinkMan
{
    /// <summary>
    /// 联系人（详细信息表）
    /// </summary>
    public class LinkDetailInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int LDId { get; set; }
        /// <summary>
        /// 机构名称
        /// </summary>
        public string LDOrgan { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string LDName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool LDSex { get; set; }
        /// <summary>
        /// 职务
        /// </summary>
        public string LDDuty { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public int LDPhone { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string LDTelephone { get; set; }
        /// <summary>
        /// 传真
        /// </summary>
        public string LDFax { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string LDMailbox { get; set; }
        /// <summary>
        /// QQ
        /// </summary>
        public int LDQQ { get; set; }
        /// <summary>
        /// 微信 
        /// </summary>
        public string LDWeChat { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        public string LDSite { get; set; }
        /// <summary>
        /// 重要等级
        /// </summary>
        public string LDGrade { get; set; }
        /// <summary>
        /// 跟进状态
        /// </summary>
        public string LDFState { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string LDOperator { get; set; }
        /// <summary>
        /// 是否认可
        /// </summary>
        public string LDAccept { get; set; }
        /// <summary>
        /// 认可理由 
        /// </summary>
        public string LDReason { get; set; }
        /// <summary>
        /// 信息来源
        /// </summary>
        public string LDSource { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string LDRemark { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int LDState { get; set; }
    }
}
