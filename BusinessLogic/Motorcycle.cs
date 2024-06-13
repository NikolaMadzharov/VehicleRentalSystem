namespace VehicleRentalSystem.BusinessLogic;

public class Motorcycle : Vehicle
{
    public int Age { get; set; }

    public override decimal TotalRentalCostPerDay()
    {

        if (RentalDays > 7)
        {
            return 1 * 10;
        }

        return 1 * 15;
    }

    public override decimal TotalInsuranceCostPerDay()
    {
        return Value * 0.0002m;
    }

    public override decimal AdditionInsurancePerDay()
    {
        if (Age < 25)
        {
            return 0.20m * TotalInsuranceCostPerDay();
        }

        return 0.00m;
    }
}
