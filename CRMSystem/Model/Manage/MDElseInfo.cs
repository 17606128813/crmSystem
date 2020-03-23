using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Manage
{
    /// <summary>
    /// 机构信息管理（其他信息详情表）
    /// </summary>
    public class MDElseInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int MEId { get; set; }
        /// <summary>
        /// 经办人
        /// </summary>
        public string MEAgent { get; set; }
        /// <summary>
        /// 年费
        /// </summary>
        public string MEAnnual { get; set; }
        /// <summary>
        /// 电子资源经费
        /// </summary>
        public string MEResour { get; set; }
        /// <summary>
        /// 采购时间
        /// </summary>
        public string METime { get; set; }
        /// <summary>
        /// 采购级别
        /// </summary>
        public string MELevel { get; set; }
        /// <summary>
        /// 采购方式 
        /// </summary>
        public string MEWay { get; set; }
        /// <summary>
        /// 机构类型  
        /// </summary>
        public string METype { get; set; }
        /// <summary>
        /// 采购途径
        /// </summary>
        public string MEApproach { get; set; }
        /// <summary>
        /// 分配情况
        /// </summary>
        public string MEAllocation { get; set; }
        /// <summary>
        /// 商机状态
        /// </summary>
        public string MEBusiness { get; set; }
        /// <summary>
        /// 备注信息 
        /// </summary>
        public string MERemark { get; set; }
        /// <summary>
        /// 合同信息
        /// </summary>
        public string MEContract { get; set; }
        /// <summary>
        /// 产品信息
        /// </summary>
        public string MEProduct { get; set; }
        /// <summary>
        /// 跟进状态
        /// </summary>
        public string MEFollow { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int MEState { get; set; }
    }
}
