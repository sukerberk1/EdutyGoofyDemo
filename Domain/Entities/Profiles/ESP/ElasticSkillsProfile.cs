using Domain.Entities.Aggregates;
using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Profiles.ESP
{
    public class ElasticSkillsProfile : LearningProfile
    {
        public List<ProgressBlock> ProgressBlocks = new();

        public override void Adjust(LearningAction learningAction)
        {
            if(!ProgressBlocks.ConvertAll(o=>o.LearningElement).Contains(learningAction.LearningElement))
            {
                ProgressBlock progressBlock = new(learningAction.LearningElement);
                ProgressBlocks.Add(progressBlock);
                return;
            }
            var searchedBlock = ProgressBlocks.Find(o => o.LearningElement == learningAction.LearningElement);
            searchedBlock.Experience += 5;
            searchedBlock.LastInteraction = DateTime.Now;
            LastUpadate = DateTime.Now;
        }

        public void Display()
        {
            foreach(var block in ProgressBlocks) 
            {
                Console.WriteLine($"{block.LearningElement.Title} - experience: {block.Experience}");
            }
        }
    }
}
