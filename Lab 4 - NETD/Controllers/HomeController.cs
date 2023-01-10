/*
 * Name: Shivam Janda
 * Date: November 21, 2022
 * Description: Home controller and its actions
 */
using Lab_4___NETD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_4___NETD.Controllers
{
    public class HomeController : Controller
    {
        // create a list of textbooks used view apparials 
        public static List<textbook> textbooks = new List<textbook>();

      
        public IActionResult Index()
        {
            // returns index view
            return View();
        }

     
        /// <summary>
        /// Differtiantes with the two methods. Gets the the page for appraise
        /// </summary>
        /// <returns></returns>
        [HttpGet] public IActionResult Appraise()
        {
            return View();
        }

        /// <summary>
        /// whem the user presses the appraise button
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        [HttpPost] public IActionResult Appraise(textbook a)
        {
            if (ModelState.IsValid)
            {
               
                ViewData["TextbookTitle"] = "Textbook Title: " + a.title;
                ViewData["Version"] = "Verison: " + a.version;
                ViewData["AppraisedPrice"] = "Appraised at: $" + a.appraisedPrice(a.price, a.condition);
                //ad the textbook to the list of textbooks
                textbooks.Add(a);
                // if the texbook is valid then show the view appraisal screen
                return View("ViewApprasial", a);
            }
            else
            {
                // otherwise return the failure screen
                return View("FailureScreen");
            }

       
        }

        /// <summary>
        /// will call the viewapprasials page
        /// </summary>
        /// <returns></returns>
        public IActionResult ViewApprasials()
        {
            // view the list of textbook objects
            ViewBag.textbooks = textbooks;
            return View();
        }
       
    }
}
