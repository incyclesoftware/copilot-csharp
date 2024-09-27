using Microsoft.AspNetCore.HttpLogging;

namespace IncycleAirways.Data
{
    public class PlanePassenger : Person
    {
        protected PlanePassenger() { }
        required public string PassportNumber { get; set; }
        public static PlanePassenger CreateFromCSVLine(string text)
        {
            var fields = text.Split(',');
            return new PlanePassenger
            {
                FirstName = fields[0],
                LastName = fields[1],
                DateOfBirth = DateTime.Parse(fields[4]),
                EmailAddress = fields[2],
                PhoneNumber = fields[3],
                PassportNumber = fields[5],
            };
        }
    }
}
