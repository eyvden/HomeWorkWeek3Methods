using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class CustomerManager
    { 
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.FamilyName + " has been added.");
            Console.WriteLine("-----------------------------------");

        }

        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.FamilyName + " has been deleted.");
            Console.WriteLine("-----------------------------------");

        }

        public void List(Customer[] customer)
        {

            Console.WriteLine("Customer List: \n");
            foreach (var customers in customer)
            {        
                Console.WriteLine("Name: "+customers.Name + " / " +"Family Name: "+customers.FamilyName + " / " + "Balance: " + customers.Balance + " EUR");
            }
        }


    }
}
