using Domain.Entities.Common;
using Domain.Entities.TreeBasedCurriculum.Lesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Profiles.ESP
{
    public class ProgressBlock
    {
        int experience = 5;
        public LearningElement LearningElement { get; set; }
        public int Experience { get => experience;
            set
            { if (value > 100 || value < 0) return;
                else experience = value;
            }
        }
        public DateTime LastInteraction { get; set; } = DateTime.Now;

        public ProgressBlock(LearningElement element)
        {
            LearningElement = element;
        }

        public ProgressBlock(LearningElement element, int experience, DateTime lastInteraction)
        {
            LearningElement = element;
            Experience = experience;
            LastInteraction = lastInteraction;
        }
    }
}
