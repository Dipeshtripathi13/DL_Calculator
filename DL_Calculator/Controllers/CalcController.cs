using DL_Calculator.Data;
using DL_Calculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Reflection.Metadata.Ecma335;

namespace DL_Calculator.Controllers
{
    public class CalcController : Controller
    {
        private readonly DataContext _context;

        public CalcController(DataContext context)
        {
           _context = context;
        }
        public decimal GetResources(int overLeft, int wicketLost)
        {
            var dlValue = _context.dl_Values.FirstOrDefault(d => d.over_left == overLeft && d.wicket_lost == wicketLost);
            if (dlValue != null)
            {
                return dlValue.resources;
            }
            else
            {
                // handle the case when no matching record is found in the database
                return 0;
            }
        }
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

                //c.B_target = c.A_run + c.A_wicket + c.B_wicket + c.B_over + c.Max_over;
                float B_resource = (float)GetResources((50-c.B_over),c.B_wicket);
                c.B_target = (int)(c.A_run * (1-B_resource/100)+1);


            }
           
            return View(c);

        }


    }
}
