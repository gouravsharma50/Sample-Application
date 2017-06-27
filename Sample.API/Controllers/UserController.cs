using Sample.Business;
using Sample.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample.API.Controllers
{

    public class UserController : ApiController
    {

        [HttpPost]
        public IHttpActionResult Register(UserModel userModel)
        {
            UserBusiness userBusiness = new UserBusiness();
            userBusiness.RegisterUser(userModel);
            return Ok("Yes");
        }

        public IHttpActionResult Login(UserModel userModel)
        {
            UserBusiness userBusiness = new UserBusiness();
            var user = userBusiness.LoginUser(userModel);
            return Ok("Yes");
        }



    }
}
