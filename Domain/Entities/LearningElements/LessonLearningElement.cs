using Domain.Entities.Common;
using Domain.Entities.TreeBasedCurriculum.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LearningElements;

public class LessonLearningElement : LearningElement
{
    public List<Subject> ShallowLinks = new List<Subject>();
    public List<LessonLearningElement>? Previous { get; set; } = null;
    public List<LessonLearningElement> Next { get; set; } = new();
    public Topic Topic { get; set; }
    public bool IsFundamental { get; set; } = false;


    public LessonLearningElement(string title) : base(title) { }
    public LessonLearningElement(string title, List<LessonLearningElement> prev) : base(title)
    {
        Previous = prev;
    }
}
