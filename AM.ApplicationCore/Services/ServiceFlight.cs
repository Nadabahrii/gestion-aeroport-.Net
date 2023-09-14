using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
=======
<<<<<<< HEAD
=======
using Microsoft.VisualBasic;
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
<<<<<<< HEAD
using System.Security.Cryptography.X509Certificates;
=======
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
>>>>>>> 5b057c77e90a803772b28684946df5cd8e4b3ab2
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();
<<<<<<< HEAD
        public List<Passenger> Passengers { get; set; } = new List<Passenger>();

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {

                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination.Equals(filterValue))
                        {
                            Console.WriteLine(flight.Destination);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight.FlightDate);
                        }
                    }
                    break;
                case "Estimated value":
                    foreach (var flight in Flights)
                    {
                        if (flight.EstimatedArrival == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight.EstimatedArrival);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("choix erronée");
                    break;

            }
        }

        public List<DateTime> FlightDates(string destination)
        {
            List<DateTime> date = new List<DateTime>();

            /*  for (int i = 0; i < Flights.Count; i++)
              {
                  if (Flights[i].Destination == destination)
                  {
                      date.Add(Flights[i].FlightDate);
                  }

              }*/

            /*  var query=from fligh in Flights
                        where fligh.Destination.Equals(destination)
                        select fligh.FlightDate;

              return query.ToList();*/

            var query2 = Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate);

            return query2.ToList();


            /* foreach (var flight in Flights)
             {
                 if (flight.Destination == destination)
                 {
                     date.Add(flight.FlightDate);
                 }
             }
             return date;*/
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query = from flight in Flights
                        where flight.Plane == plane
                        select new
                        {
                            flight.Destination,
                            flight.FlightDate,
                        };
            var query2 = Flights.Where(f => f.Plane == plane).Select(f => new
            {
                f.Destination,
                f.FlightDate,
            });
            foreach (var flight in query2)
            {
                Console.WriteLine("destination = " + flight.Destination + "flight date =" + flight.FlightDate);
            }

        }

        public int ProgrammedFlight(DateTime startDate)
        {
            /*var query = from fligh in Flights
                        where fligh.FlightDate.CompareTo(startDate) > 0 && (fligh.FlightDate - startDate).TotalDays < 7
                        select fligh;*/

            var query = Flights.Where(f => f.FlightDate.CompareTo(startDate) > 0 && (f.FlightDate - startDate).TotalDays < 7);

            return query.Count();
        }

        public double DurationAverage(string destination)
        {
            var query = from flights in Flights
                        where flights.Destination == destination
                        select flights.EstimatedDuration;

            var query2 = Flights.Where(f => f.Destination == destination).Select(f => f.EstimatedDuration);
            return query.Average();


        }
        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from flights in Flights
                        orderby flights.EstimatedDuration
                        descending
                        select flights;
            var query2=Flights.OrderByDescending(f => f.EstimatedDuration);
            return query;
        }

        public IEnumerable<Passenger> SeniorTravellers(Flight flight)
        {

            var oldTravellers = from p in Passengers.OfType<Traveller>()
                                orderby p.BirthDate
                                select p;
            var qr = Passengers.OrderBy(p => p.BirthDate);
            return qr.Take(3);
            //if we want to skip 3
            //return oldTravellers.Skip(3);
           
        }
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupeFlights()
        {
            var query = from flight in Flights
                        group flight by flight.Destination;
            //var query2 = Flights.GroupBy(f => f.Destination);
            foreach (var g in query)
            {
                Console.WriteLine("destination:" + g.Key);
                foreach (var flight in g)
                {
                    Console.WriteLine("decollage:" + flight.FlightDate);
                }
            }
            return query;

        }
    }
}
=======


        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            for (int i = 0; i < Flights.Count; i++)
            {
                if (Flights[i].Destination == destination)
                {
                    dates.Add(Flights[i].FlightDate);
                }
            }
            return dates;
        }
        public List<DateTime> GetFlightDates2(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            Flights.ForEach(f =>
            {
                if (f.Destination == destination)
                {
                    dates.Add(f.FlightDate);
                };
            }
            );
            return dates;
        }

        public IEnumerable<DateTime> GettFlightDates(string destination)
        {

            foreach (Flight flight in Flights)
            {
                if (flight.Destination == destination)
                {

                    yield return flight.FlightDate;
                }
            }

        }

        public void GetFlights(string filterValue, Func<string, Flight, Boolean> func)
        {

            Func<string, Flight, Boolean> Condition = func;
            foreach (var item in Flights)
            {
                if (Condition(filterValue, item))
                {
                    Console.WriteLine(item);
                }
            }
        }

<<<<<<< HEAD
        //LINQ syntaxe des requete
        public IList<DateTime> GetFlightDateslinq(string destination)
        {
            var query=from f in Flights where f.Destination == destination select f.FlightDate; 
        return query.ToList();
        }
        // Syntaxe des methodes
        public IList<DateTime> GetFlightDateslinq2(string destination) {
            var query = Flights.
           Where(f => f.Destination == destination)
           .Select(f => f.FlightDate);
            return query.ToList();

          }
        // LINQ Requete
        public void ShowFlightDetails(Plane plane)
        {
            var req = from f in Flights
                      where (f.plane == plane)
                      select new { f.FlightDate, f.Destination };
            foreach (var item in req)
            {
                Console.WriteLine(item.Destination + " " + item.FlightDate);
            }
        }
            // LINQ Des method
            public void ShowFlightDetails2(Plane plane) {

                var req = Flights.Where(f => f.plane == plane).Select(f => new { f.FlightDate, f.Destination });
                foreach (var item in req)
                {
                    Console.WriteLine(item.Destination + " " + item.FlightDate);
                }
            }
        //Retourner le nombre de vols programmés pour une semaine(7jours) à partir d’une date
        // donnée

          public int ProgrammedFlightNumber(DateTime startDate)
        {
            return Flights.Where(f => f.FlightDate > startDate && ((f.FlightDate - startDate).TotalDays < 7)).Count();
        }

        // LINQ Syntaxe
        public IList<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights orderby f.EstimatedDuration descending select f;
            return query.ToList();
        }
        // LINQ Des method
        public IList<Flight> OrderedDurationFlights2()
        {
            return Flights.OrderByDescending(f => f.FlightDate).ToList();
        }
        public IList<Traveller> SeniorTravellers(Flight flight)
        {
            var query = (from f in Flights where f.FlightId == flight.FlightId select f).Single();
            return query.passangers.OfType<Traveller>().ToList().OrderBy(p=>p.BirthDate).Take(3).ToList();
        }
        public double DurationAverage(string destination)
        {
            //var query = from f in Flights
            //where f.Destination == destination select f;
            //return query.Average (f=>f.EstimatedDuration);
            var query = Flights
            .Where(f => f.Destination == destination)
            .Average(f => f.EstimatedDuration);
            return query;
}

        public IList<IGrouping<string,Flight>> DestinationGroupedFlights()
        {
            var req = Flights.GroupBy(f => f.Destination).ToList();
            foreach(var item1 in req)
            {

                Console.WriteLine(item1.Key);
                foreach(var item2 in item1)
                {
                    Console.WriteLine("Décollage : "+item2.FlightDate);
                }
            }
            return req.ToList();
        }

      
        Action<Plane> FlightDetailsDel { get ; set; }
        Func<string, double> DurationAverageDel { get; set; }
        public ServiceFlight()
        {
            //FlightDetailsDel = ShowFlightDetails;
            DurationAverageDel = DurationAverage;
            FlightDetailsDel = plane =>
            {
                var req = from f in Flights
                          where (f.plane == plane)
                          select new { f.FlightDate, f.Destination };
                foreach (var item in req)
                {
                    Console.WriteLine(item.Destination + " " + item.FlightDate);
                }
            };
            DurationAverageDel = destination =>
            {
                var query = Flights
           .Where(f => f.Destination == destination)
           .Average(f => f.EstimatedDuration);
                return query;
            };
        
        }
  
    }

}
=======
    }

    // LINQ

    public IList<DateTime> GetFlightDates2(string destination)
    {
        /*var query= from f in flights
                   where f.Destination == destination
                   select f.FlightDate;
        return query.ToList();*/
        var query = Flights
            .where(f => f.Destination == destination);
        .Select(f => f.FlightDate);
        return query.ToList();
    }

    public void ShowFlightDetails(Plane plane)
    {
        /*var req = from f in Flights
                  where (f.MyPlane == plane)
                  select new { f.FlightDate, f.Destination };
        foreach (var item in req)
        {
            Console.WriteLine(item.Destination+" "+item.Flighdate);
        }*/
        var req = Flights 
                .Where (f => f.Destination)
                .Select (f => new { f.FlightDate, f.Destination })
       foreach (var item in req)
        {
            Console.WriteLine(item.Destination + " " + item.Flighdate);
        }
    }

    public int ProgrammedFlightNumber(DateTime startDate)
    {
        /*var req = from f in Flights
                      // where (f.FlightDate > startDate && f.FlightDate < startDate.AddDays(7))
                  where ( f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7 )
                  select f;
        return req.count();*/

        return Flights
            .Where(f = > f.Flighdate > startDate && (from.FlightDate - startDate).TotalDays < 7)
            .Count();
    }

    public float DurationAverage(string Destination)
    {
        /*var query = from f in Flights
                    where f.Destination == Destination
                    select f;
        return query.Average(f => f.EstimatedDuration);*/
        var query = Flights
                .Where((f) => f.Destination == Destination)
                .Average(f => f.EstimatedDuration);
        return query.Average();
    }
    public IList<Flight> OrderedDurationFlights()
    {
        /*var query = from f in Flights
                    orderby f.EstimatedDuration descending
                    select f;
        return query.ToList();*/
        return Flights
            .orderbydescending(f => f.EstimatedDuration)
            .ToList();
    }
    public IList<Traveller> SeniorTravellers(Flight flight)
    {
        /*var query = (from f in Flights
                    where f.FlightId == flight.FlightId
                    select f).Single();*/
        return flight.passanger
            .OfType<Traveller>()
            .OrderBy(p => p.BirthDate)
            .Take(3)
            .ToList();
    }

    public IList<IGrouping<string, Flight>> DestinationGroupedFlights()
    {
        var req = Flights
            .GroupBy(f => f.Destination).ToList();
        foreach (var item in req)
        {
            Console.WriteLine("Destinatin:"+item.key);
            foreach (var item2 in item)
            {
                Console.WriteLine("Décollage:"+item2.FlightDate);
            }
        }
        return req;
    }
    Action<Plane> FlightDetailsDel;
    Func<string, double> DurationAverageDel;
    
    public ServiceFlight()
    {

    }
}


>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
>>>>>>> 5b057c77e90a803772b28684946df5cd8e4b3ab2
