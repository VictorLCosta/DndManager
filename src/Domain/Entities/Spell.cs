using System.Collections.Frozen;

namespace Domain.Entities;

public class Spell : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? HigherLevel { get; set; }
    public string Range { get; set; } = string.Empty;
    public ICollection<char> Components { get; set; } = [];
    public string Material { get; set; } = string.Empty;
    public bool Ritual { get; set; }
    public string Duration { get; set; } = string.Empty;
    public bool Concentration { get; set; }
    public CastingTime CastingTime { get; set; }
    public int Level { get; set; }
    public AttackType AttackType { get; set; }

    public DamageType? DamageType { get; set; }
    public FrozenDictionary<int, Dice>? DamagePerSlot { get; set; }

    public FrozenDictionary<int, Dice>? DamageAtCharacterLevel { get; set; }

    public FrozenDictionary<int, Dice>? HealPerSlots { get; set; }

    public DifficultyClass? DifficultyClass { get; set; }

    public AreaOfEffect? AreaOfEffect { get; set; }

    public Guid MagicSchoolId { get; set; }
    public MagicSchool MagicSchool { get; set; } = null!;

    public ICollection<DndClass> Classes { get; set; } = [];
    public ICollection<SubclassSpell> Subclasses { get; set; } = [];
}
