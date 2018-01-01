using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Stores2Entities Context = new Stores2Entities())
            {
                //Add Customer
                //Customer cust = new Customer();
                //cust.CustomerID = 20;
                //cust.CustomerName="Amr";
                //Context.Customers.Add(cust);
                //Context.SaveChanges();

                //Retrive Customer 
                //Customer cust2 = Context.Customers.FirstOrDefault(c => c.CustomerID == 1);
                //Console.WriteLine(cust2.CustomerName);
                //Console.ReadLine();

                //Update Customer 
                //Customer cust3 = Context.Customers.FirstOrDefault(c => c.CustomerID == 20);
                //cust3.CustomerName = "Seif";
                //Context.SaveChanges(); 
                //Console.ReadLine();

                //Delete Table row
                //Customer cust4 = Context.Customers.FirstOrDefault(c => c.CustomerID == 20);
                //Context.Customers.Remove(cust4);
                //Context.SaveChanges();

                //Joining 
                //Order or1 = Context.Orders.FirstOrDefault(o => o.OrderID==11);
                //Console.WriteLine(or1.Customer.CustomerName);
                //Console.ReadKey();

            }
        }
    }
}

