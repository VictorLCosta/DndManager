namespace Domain.Common
{
    public abstract class Item : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Price { get; set; }
        public int Weight { get; set; }

        public bool IsConsumable { get; set; }
    }
}