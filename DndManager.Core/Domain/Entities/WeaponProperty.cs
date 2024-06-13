namespace DndManager.Core.Domain.Entities;

public class WeaponProperty : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Slug { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public ICollection<Weapon> Weapons { get; set; } = [];
}
