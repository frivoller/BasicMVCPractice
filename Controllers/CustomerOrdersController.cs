using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class CustomerOrdersController : Controller
{
    public IActionResult Index()
    {
        // Örnek müşteri
        var customer = new Customer
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com"
        };

        // Örnek siparişler
        var orders = new List<Order>
        {
            new Order { Id = 1, ProductName = "Laptop", Price = 1500.00M, Quantity = 1 },
            new Order { Id = 2, ProductName = "Mouse", Price = 25.00M, Quantity = 2 },
            new Order { Id = 3, ProductName = "Keyboard", Price = 50.00M, Quantity = 1 }
        };

        // ViewModel'i oluştur
        var viewModel = new CustomerOrderViewModel
        {
            Customer = customer,
            Orders = orders
        };

        // View'a ViewModel'i ilet
        return View(viewModel);
    }
}
