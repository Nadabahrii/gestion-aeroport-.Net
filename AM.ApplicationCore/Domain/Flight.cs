using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations.Schema;
=======
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
>>>>>>> 5b057c77e90a803772b28684946df5cd8e4b3ab2
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
<<<<<<< HEAD

        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public DateTime EstimatedArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public virtual ICollection<Passenger> Passengers { get; set; }
        public virtual Plane Plane { get; set; }
        public string Airline { get; set; }
        public int PlaneId { get; set; } //cle etranger
        public virtual ICollection<Ticket> tickets { get; set; }


        public override string ToString()
        {
            return "Destination" + Destination + "Departure" + Departure + "FlightDate" + FlightDate + "EffectiveArrival" + EstimatedArrival + "EstimatedDuration" + EstimatedDuration;
=======
        public string Destination { get; set; }
        public string Departure { get; set; }  
        public DateTime FlightDate { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
<<<<<<< HEAD

        [ForeignKey("Plane")]
        public int PlaneId { get; set; }
=======
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
        public Plane plane { get; set; }
        
        public IList<Passanger> passangers { get; set; }
        public override string ToString()
        {
            return $"FlightId: {FlightId}, Destination: {Destination}, Departure: {Departure}, FlightDate: {FlightDate}, EffectiveArrival: {EffectiveArrival}, EstimatedDuration: {EstimatedDuration}";
>>>>>>> 5b057c77e90a803772b28684946df5cd8e4b3ab2
        }
    }
}
