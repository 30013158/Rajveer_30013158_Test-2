//Name - Rajveer Kaur
//Purpose - test 2 based on classes in c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the staff payroll screen");
            Console.WriteLine("enter 1. to display Salary");
            Console.WriteLine("enter 2. to display Wages");
            Console.Write("Enter option: ");
            int option = int.Parse(Console.ReadLine());

            Console.WriteLine();//adding blank spaces
            Console.WriteLine();

            //using if statements to run either Salary or Wages
            if (option == 1)
            {
                Salary s1 = new Salary();//object of Salary class created
                Console.WriteLine(s1.DisplaySalary());


                Console.WriteLine();//adding 2 blank lines
                Console.WriteLine();
            }

            else if (option == 2)
            {
                Wages w1 = new Wages();//object of Wages class created
                Console.Write("Enter the number of hours worked: ");
                int numhours = int.Parse(Console.ReadLine());
                Console.WriteLine(w1.DisplayWages(numhours));
                Console.ReadLine();
            }
            Console.ReadLine();


        }
    }
    public class Salary
    { //instance variables
        private double annualsalary;
        private double weeklysalary;

        //getters and setters
        public double Annualsalary { get { return annualsalary; } set { annualsalary = 80000; } }
        public double Weeklysalary { get { return weeklysalary; } set { weeklysalary = value; } }

        // DisplaySalary method
        // no. of weeks = 365/7= 52;
        public string DisplaySalary()
        {  double income = 80000 / 52;
            return $"Your salary per week is $ {Math.Round(income, 2)}";
        }

        //constructor
        public Salary()
        {
            Console.WriteLine("Your salary is set at 80000 per year");
            Annualsalary = 80000;
        }
    }
       public class Wages
        { //instance variables
            private double hourlyRate;
            private double weeklyWages;
            private int numHours;

         //getters and setters
         public double HourlyRate { get { return hourlyRate; } set { hourlyRate = 33.72; } }
        public double WeeklyWages { get { return weeklyWages; } set { weeklyWages = value; } }
        public int Numhours { get { return numHours; } set { numHours = value; } }

        //DisplayWages method
        public string DisplayWages( int numhours)
        { double week = numhours * 33.72;
            return $"Your wages per week is ${Math.Round(week, 2)}";
        }

        //constructor
        public Wages()
        { Console.WriteLine("I will calculate your wages"); }

    }

}
