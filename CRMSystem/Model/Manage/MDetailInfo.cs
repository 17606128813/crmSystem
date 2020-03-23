using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Manage
{
    /// <summary>
    /// 机构信息管理（基本信息详情表）
    /// </summary>
    public class MDetailInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int MDId { get; set; }
        /// <summary>
        /// 机构名称
        /// </summary>
        public string MDName { get; set; }
        /// <summary>
        /// 机构地址
        /// </summary>
        public string MDSite { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        public string MDLink { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
        public int MDPhone { get; set; }
        /// <summary>
        /// 电话
        /// </summary>
        public string MDTelephone { get; set; }
        /// <summary>
        /// 国家
        /// </summary>
        public string MDNation { get; set; }
        /// <summary>
        /// 省份
        /// </summary>
        public string MDProvince { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string MDCity { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public int MDCode { get; set; }
        /// <summary>
        /// 网站
        /// </summary>
        public string MDWebsite { get; set; }
        /// <summary>
        /// 机构级别
        /// </summary>
        public string MDRank { get; set; }
        /// <summary>
        /// 行业类别
        /// </summary>
        public string MDCotegory { get; set; }
        /// <summary>
        /// 重要级别
        /// </summary>
        public string MDLevel { get; set; }
        /// <summary>
        /// 单位级别
        /// </summary>
        public string MDUnitLevel { get; set; }
        /// <summary>
        /// 区域级别
        /// </summary>
        public string MDRegLevel { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public int MDState { get; set; }
    }
}
