﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiSDKClient.FApi.Request.User
{
    public class UserUpdateRequest:BaseRequest
    {
        public override string GetApiName()
        {
            return "api/User/AddUser";
        }
    }
}
