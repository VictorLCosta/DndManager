namespace Domain.ExtendedAttributes;

public class Multiclassing
{
    public Prerequisite[] Prerequisites { get; set; } = [];
    public PrerequisiteOption[] PrerequisiteOptions { get; set; } = [];
    public ProficiencyChoice[] ProficiencyChoices { get; set; } = [];
    public Guid[] Proficiencies { get; set; } = [];

    public class Prerequisite
    {
        public AbilityScore AbilityScore { get; set; }
        public int MinimumScore { get; set; }
    }

    public class PrerequisiteOption
    {
        public string Type { get; set; } = string.Empty;
        public int Choose { get; set; }
        public From1[] Options { get; set; } = [];
    }

    public class From1
    {
        public AbilityScore AbilityScore { get; set; }
        public int MinimumScore { get; set; }
    }

    public class ProficiencyChoice
    {
        public int Choose { get; set;}
        public string Type { get; set; } = string.Empty;
        public Guid[] ProficiencyIds { get; set; } = [];
    }
}
