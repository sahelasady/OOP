using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Person
    {

        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UseParams();

            //out param
            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");
        }
        static void UseParams()
        {
            //Param keyword
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
        }
        static void UsePoints()
        {
            try
            {
                //Object Initialization: Syntax for quickly initalizing an object without the need to call one of its constructors to avoid creating multiple constructors
                var customer = new Customer()
                {
                    Id = 1,
                    Name = "John"
                };

                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.Name);

                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.x, point.y);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }


}
