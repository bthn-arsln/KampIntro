using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "ad1";
            customer1.LastName = "soyad1";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "ad2";
            customer2.LastName = "soyad2";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "ad3";
            customer3.LastName = "soyad3";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            customerManager.getCustomers(customers);

            customerManager.deleteCustomer(customer1.Id);
            customerManager.deleteCustomer(customer2.Id);
            customerManager.deleteCustomer(customer3.Id);
        }
    }
}
