namespace DndManager.Core.Domain.Entities;

public class Weapon : Equipment
{
    public WeaponCategory WeaponCategory { get; set; }
    public WeaponRange WeaponRange { get; set; }
    public WeaponCategoryRange WeaponCategoryRange { get; set; }

    public ICollection<Damage> Damage { get; set; } = [];
    
    public ICollection<WeaponProperty> WeaponProperties { get; set; } = null!;

}
