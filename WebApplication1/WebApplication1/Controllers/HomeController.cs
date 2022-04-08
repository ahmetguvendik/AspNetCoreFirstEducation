using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.Contexts;
using static WebApplication1.Data.Entities.Employee;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           DenemeContext context = new DenemeContext();
            /*     var entityAdd =  context.Products.Add(new Data.Entities.Product
                  {
                      Name = "Telefon",
                      Price = 5000
                  });

                  var update = context.Products.Find(1);
                  update.Price = 1;
                  update.Name = "Araba";
                  context.Products.Update(update); 

            var deleteProduct = context.Products.FirstOrDefault(p => p.Id == 1);
            context.Products.Remove(deleteProduct);
            context.SaveChanges();*/
            //var entityAdd = context.Products.Add(new Data.Entities.Product
            //{

            //    Price = 5000
            //});
            context.Employees.Add(new FullTimeEmployee
            {
                DailyWage = 200,
                Name = "Ahmet",
                lastName = "Güvendik"
            });

            context.Employees.Add(new FullTimeEmployee
            {
                DailyWage = 200,
                Name = "Ahmet2",
                lastName = "Güvendik2"
            });

            context.Employees.Add(new PartTimeEmployee
            {
                HourlyWage = 13,
                Name = "Ahmet3",
                lastName = "Güvendik3"
            });

            context.Employees.Add(new PartTimeEmployee
            {
                HourlyWage = 13,
                Name = "Ahmet4",
                lastName = "Güvendik4"
            });

            context.SaveChanges();

            return View();
        }
    }
}
