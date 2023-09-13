using Domain.Entities.Aggregates;
using Domain.Entities.Common;
using Domain.Enums;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Profiles.ELP
{
    public class ElasticLearnerProfile : LearningProfile
    {
        // !!! If There was a change made to IntelligenceType Enum, old ELPs would not change!
        Dictionary<IntelligenceType, int> Intelligence = Enum.GetValues(typeof(IntelligenceType))
    .Cast<IntelligenceType>()
    .ToDictionary(enumValue => enumValue, _ => 0);

        public void Display()
        {
            foreach(var o in Intelligence)
            {
                Console.WriteLine($"{o.Key} intelligence: {o.Value}");
            }
        }

        public override void Adjust(LearningAction action)
        {

        }
    }
}
