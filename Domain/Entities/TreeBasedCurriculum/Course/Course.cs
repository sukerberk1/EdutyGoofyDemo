using Domain.Entities.Common;
using Domain.Entities.LearningElements;
using Domain.Entities.LearningElements.CourseElements;
using Domain.Entities.Users;

namespace Domain.Entities.TreeBasedCurriculum.Course
{
    public class Course
    {
        public CourseLearningElement Start { get;set; }
        public List<CourseLearningElement> AllLearningElements { get; set; } = new();
        

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
            var touchedCourseElems = user.Esp.GetAllTouchedFrom(this);

            var possibleLearningElems = AllLearningElements
                .Where(o => !touchedCourseElems.Contains(o))
                .Where(o => touchedCourseElems.Contains(o.Previous))
                .ToList();
            return possibleLearningElems.Count > 0 ? 
                (CourseLearningElement) user.Elp.ChooseBestLearningElement(
                    possibleLearningElems.ConvertAll(o=>(LearningElement)o)
                    )
                : Start;
        }
    }
}
