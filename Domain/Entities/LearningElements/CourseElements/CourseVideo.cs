using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LearningElements.CourseElements
{
    public class CourseVideo : CourseLearningElement
    {
        public Video Video { get; set; }
        public CourseVideo(string title) : base(title) { }
    }
}
