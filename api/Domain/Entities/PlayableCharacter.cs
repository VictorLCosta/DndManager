namespace Domain.Entities
{
    public class PlayableCharacter : Creature
    {
        public byte[]? ProfilePhoto { get; set; }

        public Guid PlayableClassId { get; set; }
        public PlayableClass PlayableClass { get; set; } = null!;
    }
}