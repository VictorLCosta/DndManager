namespace Domain.Entities;

public class Proficiency : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public ICollection<MonsterProficiency> Monsters { get; set; } = [];
    public ICollection<DndClass> Classes { get; set; } = [];
    public ICollection<Race> Races { get; set; } = [];
    public ICollection<SubRace> SubRaces { get; set; } = [];
}
