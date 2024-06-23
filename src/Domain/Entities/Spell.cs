namespace Domain.Entities;

public class Spell : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Level { get; set; }
    public string Components { get; set; } = string.Empty;
    public string Material { get; set; } = string.Empty;
    public bool Concentration { get; set; }
    public bool Ritual { get; set; }
    public DamageType DamageType { get; set; }

    public Guid MagicSchoolId { get; set; }
    public MagicSchool MagicSchool { get; set; } = null!;

    public ICollection<DndClass> Classes { get; set; } = [];
}
