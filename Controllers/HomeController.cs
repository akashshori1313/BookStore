using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookStore.Models;
using Microsoft.Data.SqlClient;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var connectionString = "Server=DESKTOP-20DHSEV;Database=EFCoreBookStoreDb;Trusted_Connection=True";


                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                    return View();
                }
                    catch (SqlException)
                    {
                    return View();
                }
                
            }
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        [HttpGet]
        //[Route("CheckConnection")]
        public bool CheckConenction()
        {
            var connectionString = "Server=DESKTOP-20DHSEV;Database=test;uid=akash;password=test123;Initial Catalog=test;Integrated Security= true";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException Ex)
                {
                    return false;
                }

            }

        }

    }
}
