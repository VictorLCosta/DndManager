namespace DndManager.Core.Common.Models;

public abstract class Creature : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public int Level { get; set; }
    public int HitPoints { get; set; }
    public int ArmorClass { get; set; }

    public CreatureType CreatureType { get; set; }
    public Size Size { get; set; }

    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Wisdom { get; set; }
    public int Constitution { get; set; }
    public int Charisma { get; set; }

    public virtual ICollection<Equipment> Equipment { get; set; } = [];
    public virtual ICollection<Spell> Spells { get; set; } = [];
}
