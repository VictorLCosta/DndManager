namespace Domain.Entities;

public class Feature : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int Level { get; set; }

    // ? Verificar necessidade de relação direta com classe de personagem, possível engano meu
    public Guid DndClassId { get; set; }
    public DndClass DndClass { get; set; } = null!;

    public Guid? SubClassId { get; set; }
    public Subclass? SubClass { get; set; }

    public Feature? ParentFeature { get; set; }
}
