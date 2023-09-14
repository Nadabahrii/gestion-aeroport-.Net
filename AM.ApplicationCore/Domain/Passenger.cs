using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int Id { get; set; }

        public DateTime BirthDay { get; set; }

        [StringLength(7)]
        public String PassportNumber { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        //[MinLength(3,ErrorMessage ="minlength invalid")]
        //[MaxLength(25, ErrorMessage ="maxlength invalid")]
        //public string FirstName { get; set; }
        public FullName fullName { get; set; }
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public string BirthDate { get; set; }

        //   public string LastName { get; set; }
        [RegularExpression(@"^[0-9]{8}$", ErrorMessage = "Invalid Phone Number !")]
        public int TelNumber { get; set; }
        public virtual ICollection<Flight> flights { get; set; }

        public virtual ICollection<Ticket> tickets { get; set; }


        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        //public bool CheckProfile(string nom , string prenom)
        //{
        //    return (this.Firstname == nom) && (this.Lastname == prenom);
            
        //}

        //public bool CheckProfile(string nom ,string prenom , string email)
        //{
        //    return (this.EmailAddress == email) && (this.Firstname == nom) && (this.EmailAddress == email);
        //}
    }
}
