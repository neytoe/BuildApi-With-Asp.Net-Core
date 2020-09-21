using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using week10Task.Model;

namespace week10Task.Services
{
  public  interface IUserProfileMethod
    {
        public IEnumerable<UserProfile> GetAllUserProfiles();
        public UserProfile GetUserById(int id);
    }
}
