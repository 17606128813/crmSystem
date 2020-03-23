using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiSDKClient;
using BLL.ApiRequest;
using ApiSDKClient.FApi.Request.User;

namespace BLL
{
    public class UserBll
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        public void AddUser(UserAddRequest userAddRequest)
        {
            UserAddResponse response = new UserAddResponse();
            ApiRequestHelper.Post<UserAddRequest, UserAddResponse>(userAddRequest);
        }

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="request"></param>
        public void GetUserInfo(UserGetRequest request)
        {
            UserGetResponse response = new UserGetResponse();
            ApiRequestHelper.Post<UserGetRequest, UserGetResponse>(request);
        }
    }
}
