using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("A Customer Added!");
        }
        public void Update()
        {
            Console.WriteLine("A Customer Updated!");
        }
        public void Delete()
        {
            Console.WriteLine("A Customer Deleted!");
        }
        public void ToList(Customer customer)
        {
            

               
                Console.WriteLine("Müşteri Id: " + customer.Id);
                Console.WriteLine("          ");
                Console.WriteLine("Müşteri İsim ve Soyisim: " + customer.FirstName+ " "+ customer.LastName );
                Console.WriteLine("          ");
                Console.WriteLine("Müşteri Şehir: " + customer.City);
                Console.WriteLine("          ");
                Console.WriteLine("Müşteri Meslek: " + customer.Job);
                Console.WriteLine("          ");



        }
    






    }
}
