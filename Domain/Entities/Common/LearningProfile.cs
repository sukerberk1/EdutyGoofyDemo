using Domain.Entities.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Common
{
    public abstract class LearningProfile
    {
        public DateTime LastUpadate { get; set; } = DateTime.Now;
        public abstract void Adjust(LearningAction action);
    }
}
