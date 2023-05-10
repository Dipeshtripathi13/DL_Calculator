using DL_Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace DL_Calculator.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View(new calc());//give the model name instance here
        }

        //we have to post the form so write post method
        [HttpPost]
        // create the object of calc model and calculate is our button name
        public IActionResult Index(calc c, string calculate)
        {
            if (calculate == "add")
            {
                c.B_target = c.A_run + c.A_wicket + c.B_wicket + c.B_over + c.Max_over;


            }
            else
            {
                c.B_target = c.A_run + c.A_wicket + c.B_wicket + c.B_over - c.Max_over;

            }
            return View(c);

        }


    }
}
