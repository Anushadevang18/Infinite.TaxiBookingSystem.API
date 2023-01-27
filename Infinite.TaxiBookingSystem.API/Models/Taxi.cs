namespace Infinite.TaxiBookingSystem.API.Models
{
    public class Taxi
    {
        // TaxiID, TaxiModel, Color, RegistrationNumber, TaxiType

        public int TaxiId { get; set; }
        public string TaxiModel { get; set;}
        public string Color { get; set;}
        public string RegistrationNumber { get; set;}
        public string TaxiType { get; set;}
    }
}
