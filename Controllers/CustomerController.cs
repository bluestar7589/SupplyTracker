using Microsoft.AspNetCore.Mvc;
using SupplyTracker.Models;
using SupplyTracker.Models.Database;

namespace SupplyTracker.Controllers
{
    public class CustomerController : Controller
    {
        // Get: /Product/Create
        [HttpGet] // This action is hit when the user navigates to the page
        public IActionResult CreateCustomer()
        {
            return View();
        }

        // Post: /Product/Create
        [HttpPost] // This action is hit after the user submit form data
        public IActionResult CreateCustomer(Customers cus)
        {
            // Validate all data
            if (ModelState.IsValid)
            {
                // Add to database
                CustomerDB.Add(cus);
                return RedirectToAction("Index", "Home");
            }
            // If the data is not valid, return the same page with same data - error message
            return View(cus);

        }
    }
}
