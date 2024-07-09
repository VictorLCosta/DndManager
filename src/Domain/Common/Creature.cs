namespace Domain.Common;

public abstract class Creature : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Index { get; set; } = string.Empty;
    public int Level { get; set; }
    public int HitPoints { get; set; }
    public Dice HitDice { get; set; } = null!;
    public Dice HitDiceRoll { get; set; } = null!;
    public string Alignment { get; set; } = string.Empty;

    public CreatureSpeed Speed { get; set; } = null!;

    public CreatureType CreatureType { get; set; }
    public Size Size { get; set; }

    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Wisdom { get; set; }
    public int Constitution { get; set; }
    public int Charisma { get; set; }
}
