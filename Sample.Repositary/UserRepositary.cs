using Sample.Repositary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Repositary
{
    public class UserRepositary : User
    {
        private SocialMedia UnitOfWork;
        public UserRepositary(SocialMedia socialMedia)
        {
            this.UnitOfWork = socialMedia;
        }
    }
}
