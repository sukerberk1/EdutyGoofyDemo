using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LearningElements.CourseElements
{
    public class CourseFigure : CourseLearningElement
    {
        public Image Image { get; set; }
        public CourseFigure(string title, Image image) : base(title)
        {
            Image = image;
        }
    }
}
