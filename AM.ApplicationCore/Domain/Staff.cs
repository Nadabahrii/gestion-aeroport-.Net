using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
using System.Linq;
=======
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
=======
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
using System.Linq;
using System.Runtime.CompilerServices;
>>>>>>> 5b057c77e90a803772b28684946df5cd8e4b3ab2
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
<<<<<<< HEAD
    public class Staff : Passenger
    {
        public override void PassengerType()
        {
            base.PassengerType();
        }

        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        public string Function { get; set; }

        public DateTime EmployementDate { get; set; }

        public override string ToString()
        {
            return "EmployementDate" + EmployementDate + "Function" + Function + "Salary" + Salary;
        }
=======
    public class Staff:Passanger
    {
       public DateTime EmployementDate { get; set; }
       public string Function { get; set; }
<<<<<<< HEAD
        [DataType(DataType.Currency)]

        public int Salary { get; set; }
        public override string ToString()
        {
            return base.ToString()+ $"EmployementDate : {EmployementDate}, Function: {Function}, Salary: {Salary}";
=======
       public int Salary { get; set; }
        public override string ToString()
        {
            return base.ToString()+ $"EmployementDate: {EmployementDate}, Function: {Function}, Salary: {Salary}";
>>>>>>> 292464a496e201fbed13c6bbe6a28d241a4cbfbd
        }

        public override void PassangerType()
        {
            base.PassangerType();
            Console.WriteLine("staf");

        }

>>>>>>> 5b057c77e90a803772b28684946df5cd8e4b3ab2
    }
}
