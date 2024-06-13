namespace DndManager.Core.Domain.Entities;

public class Monster : Creature
{
    public int ChallengeRating { get; set; }
    public uint ExperiencePoints { get; set; }
}
