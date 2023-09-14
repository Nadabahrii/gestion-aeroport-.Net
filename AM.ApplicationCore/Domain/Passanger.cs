using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passanger
<<<<<<< HEAD

    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        [Key]
        [StringLength(7)]

        public int PassportNumber { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Display(Name = "First Name")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "First name must be between 3 and 25 characters")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Telephone Number")]

        [Required]
        [RegularExpression("^[0-9]{8}$", ErrorMessage = "Tel number must contain 8 digits")]
        public int TelNumber { get; set; }
        

        public List<Flight> flights { get; set; }
=======
    {
       public DateTime BirthDate { get; set; }
       public int PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
        public override string ToString()
        {
            return $"BirthDate: {BirthDate}, PassportNumber: {PassportNumber}, EmailAddress: {EmailAddress}, FirstName: {FirstName}, LastName: {LastName}, TelNumber: {TelNumber}";
        }
        public virtual void PassangerType()
        {
            Console.WriteLine("I am a Passenger");

        }
        public bool CheckProfil(string firstname, string lastname, string emailadress = null)
        {
            if (emailadress == null)
            {
                return FirstName == firstname && LastName == lastname;

            }
            else
            {
                return FirstName == firstname && LastName == lastname && EmailAddress == emailadress;

            }
        }
    }

}
