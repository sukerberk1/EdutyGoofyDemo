using Domain.Entities.LearningElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.TreeBasedCurriculum.Lesson
{
    // operates on subtopic level. e.g. 1st thermodynamics law
    public class Lesson
    {
        LessonLearningElement Start { get;set; }
    }
}
