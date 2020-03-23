using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using ApiSDKClient;

namespace CRMSystemUI.Controllers
{
    public class UserController : Controller
    {
        UserBll userBll = new UserBll();
        /// <summary>
        /// 注册页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        public void UerRegist()
        {
            UserAddRequest userAddRequest = new UserAddRequest();
            userBll.AddUser(userAddRequest);
        }
    }
}