using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1,FirstName= "Çisem", LastName= "Akman", City = "Aydın"}; // new yaptığın zaman customer default olarak çalışır.

            Customer customer2 = new Customer(2,"Sıla", "Akman", "Soma");

            Customer customer3 = new Customer();
            customer3.Id = 3; // default construtor'ı çalıştırır.

            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer1.FirstName);


        }
       
    }

    class Customer
    {
        //default constructor
        public Customer()//customer1 de bu çalıştı
        {

        }
        public Customer(int ıd, string firstName, string lastName, String city)//customer2 de bu çalıştı
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
