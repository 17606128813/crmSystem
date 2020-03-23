using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using Common;
using Model;
using ApiSDKClient;

namespace Bll
{
    public sealed class UserBll : BaseBll<UserBll>
    {
        UserDal userDal = new UserDal();

        /// <summary>
        /// 用户注册方法
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public UserAddResponse UserRegist(UserAddRequest request)
        {
            UserAddResponse response = new UserAddResponse();
            if (string.IsNullOrEmpty(request.UserName))
            {
                response.Status = false;
                response.Message = "手机号不能为空";
                return response;
            }
            if (string.IsNullOrEmpty(request.Pwd))
            {
                response.Status = false;
                response.Message = "密码不能为空";
                return response;
            }

            //判断手机号是否已注册
            var isExist = userDal.IsExistPhone(request.UserName);
            if (isExist)
            {
                response.Status = false;
                response.Message = "手机号已存在";
                return response;
            }

            //对密码进行加密
            //1 生成一个盐  为什么要生成一个盐？
            var salt = Generate.GenerateSalt();
            //2 加密
            var password = MD5Encrypt.MD5Encrypt32(request.Pwd + salt);

            UserInfo user = new UserInfo()
            {
                UserName = request.UserName,
                PhoneNumder = request.UserName,//13621807335
                NickName = request.UserName.ToNickName(),
                UserPass = password,
                Salt = salt
            };

            var res = userDal.UserRegist(user);
            if (res > 0)
            {
                response.IsRegistSuccess = true;
            }
            else
            {
                response.Status = false;
                response.Message = "注册失败";
            }
            return response;
        }

    }
}
