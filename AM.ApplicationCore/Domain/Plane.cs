using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
>>>>>>> 5b057c77e90a803772b28684946df5cd8e4b3ab2
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
<<<<<<< HEAD
        Boing,
        Airbus
    }
    public class Plane
    {

        public int PlaneId { get; set; }
        public PlaneType Planetype { get; set; }
        public int Capacity { get; set; }
        public DateTime ManifacturalDate { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }


        public override string ToString()
        {
            return "PlaneId  " + PlaneId + "  PlaneType" + Planetype + "Capacity" + Capacity + "ManifacturalDate" + ManifacturalDate;
        }
    }

    
=======
        Boing,Airbus
    }
    public class Plane
    {
        public Plane() { }
<<<<<<< HEAD
        [Key]

        public int PlaneId { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be a positive integer")]
=======
        public int PlaneId { get; set; }    
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public PlaneType PlaneType { get; set; }

        public IList<Flight> flights { get; set; }
        public override string ToString()
        {
            return $"PlaneID: {PlaneId}, Capacity: {Capacity}, ManufactureDate: {ManufactureDate}, PlaneType: {PlaneType}";
        }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            PlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
        }
    }
>>>>>>> 5b057c77e90a803772b28684946df5cd8e4b3ab2
}
