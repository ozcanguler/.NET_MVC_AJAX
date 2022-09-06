using CustomersAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomersAJAX.Controllers
{
    public class CustomerController : Controller
    {
        Customer customer;
        List<Customer> customers;

        public CustomerController()
        {
            customers = new List<Customer>();
            customers.Add(new Customer(0, "George", 33));
            customers.Add(new Customer(1, "Joe", 23));
            customers.Add(new Customer(2, "Ash", 13));
            customers.Add(new Customer(3, "Sam", 43));
            customers.Add(new Customer(4, "Sonya", 53));
            customers.Add(new Customer(5, "Kaz", 42));
            customers.Add(new Customer(6, "Bill", 17));
        }

        // GET: Customer
        public ActionResult Index()
        {
            //get some data - usually comes from a database 
            // in this case we will hard-code the data 

            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers,customers[0]);
            return View("Customer",tuple);
        }
        [HttpPost]
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            //get some data - usually comes from a database 
            // in this case we will hard-code the data 

            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[int.Parse(CustomerNumber)]);
            return PartialView("_CustomerDetails", customers[int.Parse(CustomerNumber)]);
        }
    }
}