using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LearningElements.CourseElements
{
    public class CourseReading : CourseLearningElement
    {
        public string Reading { get; set; }
        public CourseReading(string title, string reading) : base(title)
        {
            Reading = reading;
        }
    }
}
