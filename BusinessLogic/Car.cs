namespace VehicleRentalSystem.BusinessLogic;

public class Car : Vehicle
{

    public int SafetyRating { get; set; }

    public override decimal TotalRentalCostPerDay()
    {

        if (RentalDays > 7)
        {
             return 1 * 15;
        }

        return 1 * 20;
    }

    public override decimal TotalInsuranceCostPerDay()
    {
        return Value * 0.0001m;
    }

    public override decimal AdditionInsurancePerDay()
    {
       if (SafetyRating > 3)
        {
            return -0.10m * TotalInsuranceCostPerDay();
        }

        return 0.00m;
    }
}
