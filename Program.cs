using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Adasdada";
            customer1.FamilyName = "Bdssadaff";
            customer1.Balance = 240;

            Customer customer2 = new Customer();
            customer2.Name = "Dfdfsfs";
            customer2.FamilyName = "Etrete";
            customer2.Balance = 340;

            Customer customer3 = new Customer();
            customer3.Name = "Crwerwr";
            customer3.FamilyName = "Fdsdfe";
            customer3.Balance = 440;

            Customer[] customers = new Customer[] {customer1, customer2, customer3};
            foreach (var customer in customers)
            {
                Console.WriteLine("Name: " + customer.Name + " / Family Name: " + customer.FamilyName + " / Account Balance: "
                    + customer.Balance +" EUR");

            }

            Console.WriteLine("-------------------------");

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customers);






            Console.ReadLine();

        }
    }
}
