using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Id = 1,
                CustomerName = "Gökhan",
                CustomerSurname = "Karakuş"
            };
            Customer customer2 = new Customer
            {
                Id = 2,
                CustomerName = "Mahmut",
                CustomerSurname = "Murtaza"
            };
            Customer[] customers = new Customer[] {customer1, customer2};

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("Ekle [1] , Listele [2] , Sil [3]");
            int number = 0;
            number = Convert.ToInt32(Console.ReadLine());
            foreach (var customer in customers)
            {
                switch (number)
                {
                    case 1:
                        customerManager.Add(customer);
                        break;
                    case 2:
                        customerManager.List(customer);
                        break;
                    case 3:
                        customerManager.Delete(customer);
                        break;
                }
            }


            Console.ReadLine();
        }
    }
}
