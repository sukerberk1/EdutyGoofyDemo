using Domain.Entities.LearningElements;

namespace Domain.Entities.Profiles.ESP;

public record SkillBlock(SkillTag Tag, int TotalExperience, DateTime CreatedOn);
