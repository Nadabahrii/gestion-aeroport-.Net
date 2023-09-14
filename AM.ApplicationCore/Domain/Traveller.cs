using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
<<<<<<< HEAD
    public class Traveller : Passenger
    {
        public string Nationality { get; set; }
        public string Healthinformation { get; set; }

        public override string ToString()
        {
            return "Nationality" + Nationality + "Healthinformation" + Healthinformation;
=======
    public class Traveller:Passanger
    {
      public string HealthInformation { get; set; }
      public string Nationality { get; set; }
        public override string ToString()
        {
            return $"HealthInformation: {HealthInformation}, Nationality: {Nationality}";
>>>>>>> 5b057c77e90a803772b28684946df5cd8e4b3ab2
        }
    }
}
