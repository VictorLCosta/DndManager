using System.Collections.Frozen;

namespace Domain.ExtendedAttributes;

public class Spellcasting
{
    public int Level { get; set; }
    public AbilityScore AbilityScore { get; set; }
    public int DifficultyClass { get; set; }
    public int Modifier { get; set; }
    public string School { get; set; } = string.Empty;

    public ICollection<char> Components { get; set; } = [];
    public FrozenDictionary<int, int> SpellSlots { get; set; } = null!;

    public ICollection<SpellcastingSpell> Spells { get; set; } = [];
}
