using Domain.Entities.Common;
using Domain.Entities.Profiles.ELP;
using Domain.Entities.Profiles.ESP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Users
{
    // an end-user of the platform (a.k.a. client)
    public class StudentUser : User
    {
        public ElasticLearningProfile Elp { get; set; } = new();
        public ElasticSkillsProfile Esp { get; set; } = new();
        public StudentUser(string username) : base(username) { }

    }
}
