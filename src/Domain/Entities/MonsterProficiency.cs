namespace Domain.Entities;

public class MonsterProficiency : BaseEntity
{
    public int Value { get; set; }

    public Guid MonsterId { get; set; }
    public Monster Monster { get; set; } = null!;

    public Guid ProficiencyId { get; set; }
    public Proficiency Proficiency { get; set; } = null!;
}
