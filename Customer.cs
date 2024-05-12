using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> orders;

        //Default, parameterless constructors
        public Customer()
        {
            //It's always best practice to initialize a list with an empty list to prevent null reference exception
            orders = new List<Order>();
        }
        //We can use this keyword and specify any of the other constructors we would like to pass the control to
        public Customer(int id) : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.Name = name;
        }
    }
}
