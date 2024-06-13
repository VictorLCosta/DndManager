using System.ComponentModel;

namespace DndManager.Core.Domain.Enums;

public enum DamageType
{
    [Description("The corrosive spray of a black dragon's breath and the dissolving enzymes secreted by a black pudding deal acid damage.")]
    Acid,

    [Description("Blunt force attacks, falling, constriction, and the like deal bludgeoning damage.")]
    Bludgeoning,

    [Description("The infernal chill radiating from an ice devil's spear and the frigid blast of a white dragon's breath deal cold damage.")]
    Cold,

    [Description("Red dragons breathe fire, and many spells conjure flames to deal fire damage.")]
    Fire,

    [Description("Force is pure magical energy focused into a damaging form. Most effects that deal force damage are spells, including magic missile and spiritual weapon.")]
    Force,

    [Description("A lightning bolt spell and a blue dragon's breath deal lightning damage.")]
    Lightning,

    [Description("Necrotic damage, dealt by certain undead and a spell such as chill touch, withers matter and even the soul.")]
    Necrotic,

    [Description("Puncturing and impaling attacks, including spears and monsters' bites, deal piercing damage.")]
    Piercing,

    [Description("Venomous stings and the toxic gas of a green dragon's breath deal poison damage.")]
    Poison,

    [Description("Mental abilities such as a psionic blast deal psychic damage.")]
    Psychic,

    [Description("Radiant damage, dealt by a cleric's flame strike spell or an angel's smiting weapon, sears the flesh like fire and overloads the spirit with power.")]
    Radiant,

    [Description("Swords, axes, and monsters' claws deal slashing damage.")]
    Slashing,

    [Description("A concussive burst of sound, such as the effect of the thunderwave spell, deals thunder damage.")]
    Thunder
}
