using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer is Added!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer is Deleted!");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer is Updated!");
        }

        public void ListAll(Customer[]customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name+" "+customer.SurName);
                
            }

        }
    }
}
