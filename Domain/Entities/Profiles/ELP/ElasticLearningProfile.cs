using Domain.Entities.Aggregates;
using Domain.Entities.Common;
using Domain.Entities.Profiles.Interfaces;
using Domain.Enums;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Profiles.ELP
{
    public class ElasticLearningProfile : ILearningProfile
    {
        // !!! If There was a change made to IntelligenceType Enum, old ELPs would not change! -- change how it works
        Dictionary<IntelligenceType, int> Intelligence = Enum.GetValues(typeof(IntelligenceType))
    .Cast<IntelligenceType>()
    .ToDictionary(enumValue => enumValue, _ => 0);

        private DateTime lastUpdate = DateTime.Now;
        public DateTime LastUpadate { get => lastUpdate; set => lastUpdate = value; }

        public void Adjust(LearningAction action)
        {
            // TODO!
        }

        public LearningElement ChooseBestLearningElement(List<LearningElement> learningElements)
        {
            // TODO!
            return learningElements.First();
        }

        public void Display()
        {
            foreach (var o in Intelligence)
            {
                Console.WriteLine($"{o.Key} intelligence: {o.Value}");
            }
        }
    }
}
