


using Domain.Entities.Aggregates;
using Domain.Entities.Common;
using Domain.Entities.LearningElements;
using Domain.Entities.LearningElements.CourseElements;
using Domain.Entities.TreeBasedCurriculum.Course;
using Domain.Entities.Users;

namespace Example;

internal class Program
{

    public static Course CreateExampleCourse()
    {

        CourseVideo video1 = new CourseVideo("An initial course video");
        CourseVideo video2 = new CourseVideo("Second course lesson");
        CourseFigure figure1 = new CourseFigure("An interesting course figure", new Domain.ValueObjects.Image());
        CourseTask task1 = new CourseTask("First task", "What is 2+2", "4", Domain.Enums.IntelligenceType.Logical, Domain.Enums.IntelligenceType.Linguistic);
        CourseTask task2 = new CourseTask("Second Task", "Say my name", "Heisenberg", Domain.Enums.IntelligenceType.Visual, Domain.Enums.IntelligenceType.Interpersonal);
        CourseTask task3 = new CourseTask("Task about russia", "What is the largest country in the world", "Russia", Domain.Enums.IntelligenceType.Visual, Domain.Enums.IntelligenceType.Naturalistic);
        Course course = new Course(video1);
        course.AppendTo(video1, figure1);
        course.AppendTo(video1, task1);
        course.AppendTo(task1, video2);
        course.AppendTo(video2, task2);
        course.AppendTo(figure1, task3);
        return course;

    }

    static void Main(string[] args)
    {
        Course course = CreateExampleCourse();
        course.DisplayCourse();

        Console.WriteLine("\n------------\nLearning simulation\n------------");

        StudentUser user = new StudentUser("Alex Kutasjenko");
        for (int i = 0; i <= 3; i++)
        {
            LearningElement learningElement = course.GetLessonFor(user);
            Console.WriteLine("Picked lesson:" + learningElement.Title);

            LearningAction learningAction = new(user, learningElement);
            learningAction.Finalize();

            Console.WriteLine("Studend has ended action: " + learningElement.Title);
        }
    }
}