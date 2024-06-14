using VehicleRentalSystem.BusinessLogic;

namespace VehicleRentalSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Vehicle car = new Car()
            {
                Brand = "Toyota",
                Model = "Corolla",
                Value = 15000,
                SafetyRating = 3,
                StartOfRent = new DateTime(2024, 6, 3),
                EndOfRent = new DateTime(2024, 6, 13),
                ActualReturnDate = new DateTime(2024, 6, 13),



            };



            Invoice invoiceCar = new Invoice(car);
            invoiceCar.CalculateTotalCosts();


            Vehicle motorcycle = new Motorcycle()
            {
                Brand = "Toyota",
                Model = "Corolla",
                Value = 10000,
                Age = 20,
                StartOfRent = new DateTime(2024, 6, 3),
                EndOfRent = new DateTime(2024, 6, 13),
                ActualReturnDate = new DateTime(2024, 6, 13),



            };

            Invoice invoiceMotorcycle = new Invoice(motorcycle);
            invoiceMotorcycle.CalculateTotalCosts();

            Vehicle cargo = new CargoVan()
            {
                Brand = "Toyota",
                Model = "Corolla",
                Value = 20000,
                YearsOfExperience = 8,
                StartOfRent = new DateTime(2024,6,3),
                EndOfRent = new DateTime(2024, 6, 18),
                ActualReturnDate = new DateTime(2024, 6, 13),
                


            };

            Invoice cargoVaninvoice = new Invoice(cargo);
            cargoVaninvoice.CalculateTotalCosts();
        }
    }
}
