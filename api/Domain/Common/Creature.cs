namespace Domain.Common
{
    public abstract class Creature : BaseEntity
    {
        public string Name { get; set; } = string.Empty;

        public int HitPoints { get; set; }
        public int ArmorClass { get; set; }
        public int Speed { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public bool CanSpeak { get; set; }

        public virtual ICollection<Item> Items { get; set; } = [];
    }
}