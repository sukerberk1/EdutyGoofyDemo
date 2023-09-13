using Domain.Entities.Common;
using Domain.Entities.LearningElements;
using Domain.Entities.LearningElements.CourseElements;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Domain.Entities.TreeBasedCurriculum.Course
{
    public class Course
    {
        public CourseLearningElement Start { get;set; }
        List<CourseLearningElement> AllLearningElements { get; set; } = new();
        

        private void DisplayElement(int level, CourseLearningElement elem)
        {
            string levelIndicator = new('-', level);
            Console.WriteLine(levelIndicator + elem.Title + ' ' +
                elem switch
                {
                    CourseFigure => "[Figure]",
                    CourseReading => "[Reading]",
                    CourseTask => "[Task]",
                    CourseVideo => "[Video]",
                    _ => "[Unknown Type]"
                }
                );
            level++;
            foreach (var learningElem in elem.Next)
                DisplayElement(level, learningElem);
        }

        public void DisplayCourse() => DisplayElement(0, Start);

        public Course(CourseLearningElement start)
        {
            Start = start;
            AllLearningElements.Add(start);
        }
        public void AppendTo(CourseLearningElement elem, CourseLearningElement elemToAppend)
        {
            elem.AddNext(elemToAppend);
            AllLearningElements.Add(elemToAppend);
        }

        // get an apropraite lesson from this course according to user esp and elp
        // this function returns Starting elem even when course has been already finished
        public CourseLearningElement? GetLessonFor(StudentUser user)
        {
            var touchedCourseElems = user.Esp.ProgressBlocks.ConvertAll(o => o.LearningElement)
                .Where(o => o is CourseLearningElement)
                .Where(o=>AllLearningElements.Contains(o));

            var possibleLearningElems = new List<CourseLearningElement>();
            foreach (var elem in touchedCourseElems)
            {
                CourseLearningElement courseLearningElement = (CourseLearningElement)elem;
                foreach (var e in courseLearningElement.Next)
                {
                    if(!touchedCourseElems.Contains(e))
                        possibleLearningElems.Add(e);
                }
            }
            return possibleLearningElems.FirstOrDefault() ?? Start;
        }
    }
}
