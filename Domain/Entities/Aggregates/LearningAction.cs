using Domain.Entities.Common;
using Domain.Entities.Profiles.ESP;
using Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Aggregates;

public class LearningAction
{
    private StudentUser user;
    LearningElement learningElement;

    public LearningAction(StudentUser user, LearningElement learningElement)
    {
        User = user;
        LearningElement = learningElement;
    }

    public StudentUser User { get => user; set => user = value; }
    public LearningElement LearningElement { get => learningElement; set => learningElement = value; }

    public void Finalize()
    {
        User.Esp.Adjust(this);
        User.Elp.Adjust(this);
    }
}
