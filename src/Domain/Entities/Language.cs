namespace Domain.Entities;

public class Language : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public int LanguageType { get; set; }
}
