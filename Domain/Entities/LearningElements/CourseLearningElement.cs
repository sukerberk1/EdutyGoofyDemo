using Domain.Entities.Common;
using Domain.Entities.TreeBasedCurriculum.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.LearningElements;

public class CourseLearningElement : LearningElement
{
    public CourseLearningElement? Previous { get; set; } = null;
    public List<CourseLearningElement> Next { get; set; } = new();
    public Course Course { get; set; }
    public List<CourseLearningElement>? ShallowLinks { get; set; } = null;
    public CourseLearningElement(string title) : base(title) { }
    public CourseLearningElement(string title, CourseLearningElement prev) : base(title)
    {
        Previous = prev;
    }

    public void AddNext(CourseLearningElement elem)
    {
        Next.Add(elem);
        elem.Previous = this;
    }
}
