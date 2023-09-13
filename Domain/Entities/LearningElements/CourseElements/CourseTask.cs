using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LearningElements.CourseElements
{
    public class CourseTask : CourseLearningElement
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public IntelligenceType PrimaryIntelligence { get; set; }
        public IntelligenceType SecondaryIntelligence { get; set;}
        public CourseTask(string title, string question, string answer, IntelligenceType primary, IntelligenceType secondary) : base(title)
        { 
            Question = question;
            Answer = answer;
            PrimaryIntelligence = primary;
            SecondaryIntelligence = secondary;
        }
    }
}
