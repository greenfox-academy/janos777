﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;
using Frontend.Repositories;

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repository;

        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        [Route("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("/Doubling")]
        public IActionResult Doubling(int? input)
        {
            _repository.Create("/Doubling", input.ToString());

            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet("/Greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
        }

        [HttpGet("/AppendA/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
             return Json(new { appended = $"{appendable}a" });
        }

        [HttpPost("/Dountil/{what}")]
        public IActionResult Dountil(string what, [FromBody] Dountil dountil)
        {
            if (what == "sum")
            {
                if (dountil.Number == null)
                {
                    return Json(new { error = "Please provide a number!" });
                }
                else
                {
                    return Json(new { result = dountil.Sum(dountil.Number) });
                }
            }

            else if (what == "factor")
            {
                if (dountil.Number == null)
                {
                    return Json(new { error = "Please provide a number!" });
                }
                else
                {
                    return Json(new { result = dountil.Factor(dountil.Number) });
                }
            }

            return Json(new { error = "Please provide what to do with the numbers!" });
        }

        [HttpPost("/Arrays")]
        public IActionResult Arrays([FromBody] Arrays arrays)
        {
            if (arrays.What == "sum")
            {
                if (arrays.Numbers == null)
                {
                    return Json(new { error = "Please provide an array of numbers!" });
                }
                else
                {
                    return Json(new { result = arrays.Sum(arrays.Numbers) });
                }
            }

            else if (arrays.What == "multiply")
            {
                if (arrays.Numbers == null)
                {
                    return Json(new { error = "Please provide an array of numbers!" });
                }
                else
                {
                    return Json(new { result = arrays.Multiply(arrays.Numbers) });
                }
            }

            else if (arrays.What == "double")
            {
                if (arrays.Numbers == null)
                {
                    return Json(new { error = "Please provide an array of numbers!" });
                }
                else
                {
                    return Json(new { result = arrays.Double(arrays.Numbers) });
                }
            }

            return Json(new { error = "Please provide what to do with the numbers!" });
        }
    }
}
