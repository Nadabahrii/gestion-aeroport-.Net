using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public int numTicket { get; set; }

        public DateTime dateachat { get; set; }

        public float prixTicket { get; set; }

        public string siege { get; set; }

        public Boolean vip { get; set; }

        public int passengerfk { get; set; }

        public virtual Passenger passenger { get; set; }

        public int flightfk { get; set; }

        public virtual Flight flight { get; set; }
    }
}
