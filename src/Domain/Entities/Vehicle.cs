namespace Domain.Entities;

public class Vehicle : Equipment
{
    public VehicleCategory VehicleCategory { get; set; }
    public int? Capacity { get; set; } // measured in lbs.
    public Speed? Speed { get; set; }
}
