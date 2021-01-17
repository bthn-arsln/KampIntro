using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri eklendi: " + customer.FirstName + " " + customer.LastName);
        }
        public void getCustomers(Customer[] customers)
        {
            Console.WriteLine("Müşteriler listelendi");
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Müşeteri Adı: " + customer.FirstName + " Müşteri Soyadı: " + customer.LastName);
            }
        }
        public void deleteCustomer(int id)
        {
            Console.WriteLine(id + " id li müşteri silindi");
        }
    }
}
