using Domain.Entities.Aggregates;
using Domain.Entities.Common;
using Domain.Entities.LearningElements;
using Domain.Entities.Profiles.Interfaces;
using Domain.Entities.TreeBasedCurriculum.Course;
using Domain.Entities.TreeBasedCurriculum.Lesson;

namespace Domain.Entities.Profiles.ESP;


public class ElasticSkillsProfile : ILearningProfile
{
    public List<LearningBlock> LearningHistory = new();
    public HashSet<SkillBlock> SkillBlocks = new();

    private DateTime lastUpdate = DateTime.Now;
    public DateTime LastUpadate { get => lastUpdate; set => lastUpdate = value; }

    public void Adjust(LearningAction learningAction)
    {
        LearningBlock lb = new(learningAction.LearningElement, learningAction.Experience, DateTime.Now);
        LearningHistory.Add(lb);
    }

    public List<LearningElement> GetAllTouchedFrom(Course course)
    {
        return LearningHistory.ConvertAll(o => o.LearningElement)
                .Where(o => o is CourseLearningElement)
                .Where(o => course.AllLearningElements.Contains(o))
                .ToList();
    }

    public List<LearningElement> GetAllTouchedFrom(Lesson lesson)
    {
        throw new NotImplementedException();
    }

    public int GetTotalExperienceOf(LearningElement element)
    {
        return LearningHistory.Where(o => o.LearningElement == element).Sum(o => o.TotalExperience);
    }


    // ============ Display functions =============

    public void DisplayTotalExperienceOf(LearningElement element)
    {
        Console.WriteLine($"Total experience gained in {element.Title}: {GetTotalExperienceOf(element)}");
    }

    public void DisplayAllBlocks()
    {
        foreach(var block in LearningHistory) 
        {
            Console.WriteLine($"{block.LearningElement.Title} - experience: {block.TotalExperience}");
        }
    }

    public void DisplayBulk()
    {
        foreach (var learningElem in LearningHistory.ConvertAll(o=>o.LearningElement).Distinct())
        {
            Console.WriteLine($"Total experience in {learningElem.Title} : {GetTotalExperienceOf(learningElem)}");
        }
    }
}
