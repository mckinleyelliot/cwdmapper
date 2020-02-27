using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iLcwdMapper.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace iLcwdMapper.Controllers

{
    [Route("processors")]
    public class iLcwdMapperController : Controller
    {
        private HomeContext dbContext;
        public iLcwdMapperController(HomeContext context)
        {
            dbContext = context;
        }




        [HttpGet("")]
        public IActionResult Dashboard()
        {
            List<Processor> AllProcessors = dbContext.Processors.ToList();
            ViewBag.ApiKey = "https://maps.googleapis.com/maps/api/js?key=AIzaSyDr42YUsPp9WhD8eoNWXJBpS85Epc0F-xw&callback=myMap";
            return View(AllProcessors);
        }


        [HttpGet("new")]
        public IActionResult New()
        {
            if(HttpContext.Session.GetString("UserEmail") == null)
            {
                return RedirectToAction("LogOut", "Home");
            }
            else
            {
            return View();
            }
        }

        [HttpGet("destroy/{ProcessorId}")]
        public IActionResult Destroy (int ProcessorId)
        {
            if(HttpContext.Session.GetString("UserEmail") == null)
            {
                return RedirectToAction("LogOut", "Home");
            }
            else 
            {
            Processor remove = dbContext.Processors.FirstOrDefault(w => w.ProcessorId == ProcessorId);
            dbContext.Processors.Remove(remove);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
            }
        }

        [HttpGet("edit/{ProcessorId}")]
        public IActionResult Edit(int ProcessorId)
        {
            if(HttpContext.Session.GetString("UserEmail") == null)
            {
                return RedirectToAction("LogOut", "Home");
            }
            else
            {
            Processor RetrievedProcessor = dbContext.Processors.FirstOrDefault(p => p.ProcessorId == ProcessorId);
            return View("Edit", RetrievedProcessor);
            }
        }

        [HttpPost("edit/{ProcessorId}")]
        public IActionResult Editit(int ProcessorId, Processor ND)
        {
            if(HttpContext.Session.GetString("UserEmail") == null)
            {
                return RedirectToAction("LogOut", "Home");
            }
            else
            {
            if(ModelState.IsValid)
            {
                Processor EditProcessor = dbContext.Processors.FirstOrDefault(p => p.ProcessorId == ProcessorId);
                if(ND.ProcessorAddress != "")
                {
                    EditProcessor.ProcessorAddress = ND.ProcessorAddress;
                }
                if(ND.ProcessorName != "")
                {
                    EditProcessor.ProcessorName = ND.ProcessorName;
                }
                if(ND.ProcessorCounty != "")
                {
                    EditProcessor.ProcessorCounty = ND.ProcessorCounty;
                }
                if(ND.ProcessorCity != "")
                {
                    EditProcessor.ProcessorCity = ND.ProcessorCity;
                }
                if(ND.ProcessorHours != "")
                {
                    EditProcessor.ProcessorHours = ND.ProcessorHours;
                }
                if(ND.LAT != "")
                {
                    EditProcessor.LAT = ND.LAT;
                }
                if(ND.LNG != "")
                {
                    EditProcessor.LNG = ND.LNG;
                }
                EditProcessor.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                List<Processor> AllProcessors = dbContext.Processors.ToList();
                return RedirectToAction("AdminPage");
            }
            else {
                Processor EditProcessor = dbContext.Processors.FirstOrDefault(p => p.ProcessorId == ProcessorId);
                return View ("Edit", EditProcessor);
            }
        }
    }



        [HttpPost("create")]
        public IActionResult Create(Processor processor)
        {
            if(HttpContext.Session.GetString("UserEmail") == null)
            {
                return RedirectToAction("LogOut", "Home");
            }
            else
            {
                if(ModelState.IsValid)
                {
                    dbContext.Processors.Add(processor);
                    dbContext.SaveChanges();
                    List<Processor> AllProcessors = dbContext.Processors.ToList();
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    return View("New");
                }
            }
        }

        [HttpGet("AdminPage")]
        public IActionResult AdminPage()
        {
            if(HttpContext.Session.GetString("UserEmail") == null)
            {
                return RedirectToAction("LogOut", "Home");
            }
            else{
                List<Processor> AllProcessors = dbContext.Processors.ToList();
                return View(AllProcessors);
            }
        }





    }
}