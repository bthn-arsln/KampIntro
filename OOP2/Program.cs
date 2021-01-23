using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gerçek Müşteri
            RealCustomer customer1 = new RealCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.FirstName = "Batuhan";
            customer1.LastName = "Arslan";
            customer1.TcNo = "12345678910";

            // Tüzel Müşteri
            LegalCustomer customer2 = new LegalCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new RealCustomer();
            Customer customer4 = new LegalCustomer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
