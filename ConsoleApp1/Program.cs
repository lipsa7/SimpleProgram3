using System;

namespace ConsoleApp1
{
    public class individualdetails
    {
        public int age { get; set; }
        public string gender { get; set; }
        public int salary { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            double tax=0.0;
            individualdetails i = new individualdetails();
            Console.WriteLine("Enter the age of the individual between 24 and 60");
            i.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the gender of the individual as Male or Female");
            i.gender = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            i.salary = Convert.ToInt32(Console.ReadLine());

            

            if (i.age < 24)
            {
                if (i.gender == "Male")
                {
                    tax += i.salary * 0.1;
                }
                else if(i.gender=="Female")
                {
                    tax += i.salary * 0.07;
                }
            }
            else if (i.age >= 24 && i.age < 40)
            {
                if (i.gender == "Male")
                {
                    tax += i.salary * 0.25;
                }
                else if (i.gender == "Female")
                {
                    tax += i.salary * 0.20;
                }
            }
            else if(i.age>=40 && i.age < 60)
            {
                if(i.gender == "Male")
                {
                    tax += i.salary * 0.15;
                }
                else if (i.gender == "Female")
                {
                    tax += i.salary * 0.12;
                }
            }
            else if (i.age >= 60)
            {
                if (i.gender == "Male")
                {
                    tax += i.salary * 0.05;
                }
                
            }
            Console.WriteLine(tax);
            Console.ReadKey();
        }
    }
}
