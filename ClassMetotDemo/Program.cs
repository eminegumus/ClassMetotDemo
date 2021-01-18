using System;
using System.ComponentModel;
using System.Threading;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Customer customer = new Customer()
            {
                Id = 1,
                IsDeleted = false,
                City = "Ankara",
                Name = "Emine",
                SurName = "Gümüş"
            };

            Customer[] customers=new Customer[]{customer};

            var customerManager=new CustomerManager();
            customerManager.Add(customer);
            customerManager.Delete(customer);
            customerManager.Update(customer);
            customerManager.ListAll(customers);
            
        }
    }
}
