namespace Domain.Entities;

public class Campaign : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }

    public ICollection<PlayableCharacter> PlayableCharacters { get; set; } = [];
}
