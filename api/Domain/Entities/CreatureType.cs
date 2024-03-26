namespace Domain.Entities
{
    public class CreatureType : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }        
    }
}