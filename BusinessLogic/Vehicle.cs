namespace VehicleRentalSystem.BusinessLogic;

public abstract class Vehicle
{
    public string Brand { get; set; }

    public string Model { get; set; }

    public decimal Value { get; set; }

    public DateTime StartOfRent { get; set; }

    public DateTime ActualReturnDate { get; set; }

    public DateTime EndOfRent { get; set; }


    public int RentalDays => (EndOfRent - StartOfRent).Days;

    public abstract decimal TotalRentalCostPerDay();

    public abstract decimal TotalInsuranceCostPerDay();

    public abstract decimal AdditionInsurancePerDay();

}
