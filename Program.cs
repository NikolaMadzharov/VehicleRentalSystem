using VehicleRentalSystem.BusinessLogic;

namespace VehicleRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car()
            {
                Brand = "Toyota",
                Model = "Corolla",
                Value = 10000,
                SafetyRating = 3,
                StartOfRent = new DateTime(2024,6,3),
                EndOfRent = new DateTime(2024, 6, 18),
                ActualReturnDate = new DateTime(2024, 6, 13),
                


            };

            Invoice invoice = new Invoice(vehicle);
            invoice.CalculateTotalCosts();
        }
    }
}
