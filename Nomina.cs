using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomina01
{
    class PayRoll:Program
    {
        private double NumberDocument;
        private string FirtsName;
        private string LastName;
        private double Salary;
        private double WorkedDays;

        public PayRoll()
        {
        }
        public PayRoll(string firtsName, string lastName)
        {
            FirtsName = firtsName;
            LastName = lastName;
        }

        public PayRoll(double numberDocument, double salary, double workedDays)
        {
            NumberDocument = numberDocument;
            Salary = salary;
            WorkedDays = workedDays;
        }

        public void setnumberdocument(double numberDocument)
        {
            this.NumberDocument = numberDocument;
        }
        public double getnumberDocument()
        {
            return NumberDocument;
        }
        public void setFirst(string firstname)
        {
            this.FirtsName = firstname;
        }
        public string getFirst()
        {
            return FirtsName;
        }
        public void setlast(string lastName)
        {
            this.LastName = lastName;
        }
        public string getlast()
        {
            return LastName;
        }
        public void setsalary(double salary)
        {
            this.Salary = salary;
        }
        public double getsalary()
        {
            return Salary;
        }
        public void setworked(double workedDays)
        {
            this.WorkedDays= workedDays;
        }
        public double getworked()
        {
            return WorkedDays;
        }




    }
}
