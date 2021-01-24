using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            
            
            CustomerManager customerManager = new CustomerManager();

           

            List<Customer> customers = new List<Customer>();

            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            Customer customer4 = new Customer();


            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);
            customers.Add(customer4);


            customer1.Id = 1;
            customer1.FirstName = "Ali";
            customer1.LastName = "Akarsu";
            customer1.City = "Çanakkale";
            customer1.Job = "Kaptan";

            customer2.Id = 2;
            customer2.FirstName = "Volkan";
            customer2.LastName = "Demirel";
            customer2.City = "İstanbul";
            customer2.Job = "Futbolcu";

            customer3.Id = 3;
            customer3.FirstName = "Tuncay";
            customer3.LastName = "Şanlı";
            customer3.City = "İstanbul";
            customer3.Job = "Futbolcu";

            customer4.Id = 4;
            customer4.FirstName = "Serhat";
            customer4.LastName = "Akın";
            customer4.City = "İstanbul";
            customer4.Job = "Futbolcu";



            customerManager.Add();
            customerManager.Update();
            customerManager.Delete();

            Console.WriteLine(" ");

            foreach (var customer in customers)
            {

             customerManager.ToList(customer);
            
            }
            Console.ReadLine();
        }
    }
}
