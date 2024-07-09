namespace Domain.Entities;

public class SubclassSpell : BaseEntity
{
    public ICollection<ClassLevel> RequiredLevel { get; set; } = [];
    public ICollection<Feature> RequiredFeatures { get; set; } = [];

    public Guid SubclassId { get; set; }
    public Subclass Subclass { get; set; } = null!;

    public Guid SpellId { get; set; }
    public Spell Spell { get; set; } = null!;
}
