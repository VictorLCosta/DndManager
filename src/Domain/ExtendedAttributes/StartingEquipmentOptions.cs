using System.Text.Json.Serialization;

namespace Domain.ExtendedAttributes;

public class StartingEquipmentOptions
{
    public int Choose { get; set; }
    public string Type { get; set; } = string.Empty;
    public From3[] From { get; set; } = [];

    public class From3
    {
        public Equipment1 Equipment { get; set; }

        public int Quantity { get; set; }

        public EquipmentOption EquipmentOption { get; set; }

        public Prerequisite[] Prerequisites { get; set; } = [];

        [JsonPropertyName("0")]
        public _0 _0 { get; set; }

        [JsonPropertyName("1")]
        public _1 _1 { get; set; }

        public Equipment_Category2 EquipmentCategory { get; set; }

        [JsonPropertyName("2")]
        public _2 _2 { get; set; }
    }

    public class Equipment1
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class EquipmentOption
    {
        public int Choose { get; set; }
        public string type { get; set; }
        public From4 from { get; set; }
    }

    public class From4
    {
        public Equipment_Category equipment_category { get; set; }
    }

    public class Equipment_Category
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class _0
    {
        public Equipment2 equipment { get; set; }
        public int Quantity { get; set; }
    }

    public class Equipment2
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class _1
    {
        public Equipment3 equipment { get; set; }
        public int quantity { get; set; }
        public EquipmentOption1 equipment_option { get; set; }
    }

    public class Equipment3
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class EquipmentOption1
    {
        public int choose { get; set; }
        public string type { get; set; }
        public From5 from { get; set; }
    }

    public class From5
    {
        public Equipment_Category1 equipment_category { get; set; }
    }

    public class Equipment_Category1
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Equipment_Category2
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class _2
    {
        public Equipment4 equipment { get; set; }
        public int quantity { get; set; }
    }

    public class Equipment4
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Prerequisite
    {
        public string Type { get; set; } = string.Empty;
        public Proficiency2 proficiency { get; set; }
    }

    public class Proficiency2
    {
        public string index { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }
}
