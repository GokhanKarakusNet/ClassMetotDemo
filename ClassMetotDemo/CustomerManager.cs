using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer Added!" + " " + customer.CustomerName);
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Customer Listed!" + " " + customer.CustomerName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted!" + " " + customer.CustomerName);
        }
    }
}
