using Domain.Entities.Common;
using Domain.Entities.Users;
using System.Security.Cryptography;

namespace Domain.Entities.Aggregates;

public class LearningAction
{
    private StudentUser user;
    LearningElement learningElement;
    private int experience = 0;

    public int Experience { get => experience; }

    public LearningAction(StudentUser user, LearningElement learningElement)
    {
        User = user;
        this.learningElement = learningElement;
    }

    public StudentUser User { get => user; set => user = value; }
    public LearningElement LearningElement { get => learningElement; }

    public void SimulateRandom()
    {
        experience = RandomNumberGenerator.GetInt32(200);
    }

    public void Finalize()
    {
        User.Esp.Adjust(this);
        User.Elp.Adjust(this);
    }
}
