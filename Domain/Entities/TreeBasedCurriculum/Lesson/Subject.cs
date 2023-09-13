using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.TreeBasedCurriculum.Lesson
{
    // e.g. physics
    public class Subject
    {
        public List<Topic> topics = new List<Topic>();
    }
}
