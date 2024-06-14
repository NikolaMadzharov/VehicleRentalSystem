using System.Text;

namespace VehicleRentalSystem.BusinessLogic;

public class Invoice
{
    private readonly  Vehicle _vehicle;

    public Invoice(Vehicle vehicle)
    {
        _vehicle = vehicle;
    }
    
    public void CalculateTotalCosts()
    {


        var sb = new StringBuilder();
        sb.AppendLine($"A {_vehicle.GetType().Name} is valued at ${_vehicle.Value}");
        sb.AppendLine($"Date: {_vehicle.StartOfRent}");
        sb.AppendLine($"Customer: Nikola Madzharov");
        sb.AppendLine($"Rented Vehicle: {_vehicle.Brand} {_vehicle.Model}");
        sb.AppendLine($"------------------------------------------------------------------------------");
        sb.AppendLine($"Reservation start date: {_vehicle.StartOfRent}");
        sb.AppendLine($"Reservation end date: {_vehicle.EndOfRent}");
        sb.AppendLine($"Reserved rental days: {_vehicle.RentalDays}");
        sb.AppendLine($"------------------------------------------------------------------------------");
        sb.AppendLine($"Actual Return Date: {_vehicle.ActualReturnDate}");
        sb.AppendLine($"Actual rental days: {(_vehicle.ActualReturnDate - _vehicle.StartOfRent).Days}");
        sb.AppendLine($"------------------------------------------------------------------------------");
        sb.AppendLine($"Total Rent cost per day: ${_vehicle.TotalRentalCostPerDay():F2}");
        sb.AppendLine($"Insurance per day: ${_vehicle.TotalInsuranceCostPerDay():F2}");
        sb.AppendLine($"Additional Insurance per day: ${Math.Abs(_vehicle.AdditionInsurancePerDay()):F2}");
        sb.AppendLine($"------------------------------------------------------------------------------");
        sb.AppendLine($"Total rent: ${TotalRentalCost():F2}");
        sb.AppendLine($"Total insurance: ${TotalInsuranceCost():F2}");
        sb.AppendLine($"Total additional insurance: ${Math.Abs(TotalAdditionalInsuranceCost()):F2}");
        sb.AppendLine($"Total: ${TotalSum():F2}");
        sb.AppendLine($"--------------------------------END OF PRINT ------------------------------------------");

        Console.WriteLine(sb.ToString());










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


    private decimal TotalSum()
    {
        var total = TotalRentalCost() + TotalInsuranceCost() + TotalAdditionalInsuranceCost();

        return total;
    }

  

}
