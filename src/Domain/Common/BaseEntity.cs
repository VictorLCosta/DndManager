using System.ComponentModel.DataAnnotations;

namespace Domain.Common;

public abstract class BaseEntity
{
    [Key]
    public Guid Id { get; set; }

    protected BaseEntity()
    {
        Id = Guid.NewGuid();
    }

    private DateTime? _createdAt;

    public DateTime? CreatedAt
    {
        get { return _createdAt; }
        set { _createdAt = value ?? DateTime.Now; }
    }

    public DateTime? LastModifiedOn { get; set; }
}
