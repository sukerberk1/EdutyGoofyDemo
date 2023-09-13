using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Users
{
    // user which is a content creator of the platform : he would create courses, lessons etc. and ofc have privilleges
    public class StaffUser : User
    {
        public StaffUser(string username) : base(username) { }
    }
}
