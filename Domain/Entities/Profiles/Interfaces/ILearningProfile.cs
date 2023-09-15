using Domain.Entities.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Profiles.Interfaces
{
    public interface ILearningProfile
    {
        public DateTime LastUpadate { get; set; }
        public abstract void Adjust(LearningAction action);
    }
}
