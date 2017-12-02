using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {

        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Jhon Smith"},
                new Customer { Id = 2, Name = "Mary Williams"}
            };
        }
    }
}