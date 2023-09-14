using Domain.Entities.Common;

namespace Domain.Entities.Profiles.ESP;

public record LearningBlock(LearningElement LearningElement, int TotalExperience, DateTime CreatedOn);
