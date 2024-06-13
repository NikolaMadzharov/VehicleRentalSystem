namespace VehicleRentalSystem.BusinessLogic;

public class Invoice
{
    private readonly Vehicle _vehicle;

    public Invoice(Vehicle vehicle)
    {
        _vehicle = vehicle;
    }

    public void CalculateTotalCosts()
    {



        Console.WriteLine($"A {_vehicle.GetType} is valued at {_vehicle.Value}");
        Console.WriteLine("XXXXXXXXXXXXXX");
        Console.WriteLine($"Date: {_vehicle.StartOfRent}");
        Console.WriteLine($"Customer: Nikola Madzharov");
        Console.WriteLine("");

        Console.WriteLine($"StartDate: {_vehicle.StartOfRent}");
        Console.WriteLine($"EndDate: {_vehicle.EndOfRent}");
        Console.WriteLine($"TotalDats: {_vehicle.RentalDays}");

        Console.WriteLine($"ActualReturnDate: {_vehicle.ActualReturnDate}");
        Console.WriteLine($"TotalRentCost: {TotalRentalCost():F2}");
        Console.WriteLine($"TotalRentCostPerDay: {_vehicle.TotalRentalCostPerDay():F2}");
        Console.WriteLine($"------------------------------------------------------------------------------");
        Console.WriteLine($"Insurance: {TotalInsuranceCost():F2}");
        Console.WriteLine($"InsurancePerDay: {_vehicle.TotalInsuranceCostPerDay():F2}");
        Console.WriteLine($"------------------------------------------------------------------------------");
        Console.WriteLine($"AdditionalInsurance: {TotalAdditionalInsuranceCost():F2}");
        Console.WriteLine($"InsurancePerDay: {_vehicle.AdditionInsurancePerDay():F2}");
       








    }

    private decimal TotalRentalCost()
    {
        var remainingDays = (_vehicle.EndOfRent - _vehicle.ActualReturnDate).Days;
        var actualDaysOfRent = (_vehicle.ActualReturnDate - _vehicle.StartOfRent).Days;

        decimal totalPrice = 0;

        if (remainingDays != 0)
        {
            totalPrice = (_vehicle.TotalRentalCostPerDay() * remainingDays) / 2 + (_vehicle.TotalRentalCostPerDay() * actualDaysOfRent);

        }
        else
        {
            totalPrice = actualDaysOfRent * _vehicle.TotalRentalCostPerDay();
        }

        return totalPrice;
    
    }

    private decimal TotalAdditionalInsuranceCost()
    {
        var actualDaysOfRent = (_vehicle.ActualReturnDate - _vehicle.StartOfRent).Days;

        return _vehicle.AdditionInsurancePerDay() * actualDaysOfRent;
    }


    private decimal TotalInsuranceCost()
    {
        var actualDaysOfRent = (_vehicle.ActualReturnDate - _vehicle.StartOfRent).Days; 

        return actualDaysOfRent * _vehicle.TotalInsuranceCostPerDay(); 
    }

  

}
