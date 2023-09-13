using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Users
{
    // a user that would be a tutor
    public class TutorUser : User
    {
        public TutorUser(string username) : base(username) { }
    }
}
