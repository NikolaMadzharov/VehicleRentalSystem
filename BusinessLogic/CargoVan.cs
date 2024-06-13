namespace VehicleRentalSystem.BusinessLogic;

public class CargoVan:Vehicle
{
    public int YearsOfExperience { get; set; }

    public override decimal TotalRentalCostPerDay()
    {

        if (RentalDays > 7)
        {
            return 1 * 40;
        }

        return 1 * 50;
    }

    public override decimal TotalInsuranceCostPerDay()
    {
        return Value * 0.0003m;
    }

    public override decimal AdditionInsurancePerDay()
    {
        if (YearsOfExperience > 5)
        {
            return -0.15m * TotalInsuranceCostPerDay();
        }

        return 0.00m;
    }
}
