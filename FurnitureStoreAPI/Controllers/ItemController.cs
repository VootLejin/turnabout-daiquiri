using FurnitureStoreAPI.DataLayer;
using FurnitureStoreAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStoreAPI.Controllers
{
    [Route("api/[controller]")]
    public class ItemController : Controller
    {
        private readonly DataFacade dataFacade;

        public ItemController(DataFacade dataFacade)
        {
            this.dataFacade = dataFacade;
        }

        // GET: ItemController
        public ActionResult Index()
        {
            //return new ObjectResult("Some Item Response");

            //var response = this.dataFacade.GetItems();

            var items = new List<Item>();

            for (var i=0; i < 10; i++)
            {
                var response = new Item
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Chair",
                    Price = 12.00
                };
                items.Add(response);
            }
            return new ObjectResult(items);
        }

        // GET: ItemController/Details/5
        [HttpGet("details/{id}")]
        public ActionResult Details(int id)
        {
            var response = new Item
            {
                Id = id.ToString(),
                Name = "Chair",
                Price = 12.00
            };
            return new ObjectResult(response);
        }

        // GET: ItemController/Create
        [HttpPost]
        public ActionResult Create()
        {
            return View();
        }

        // POST: ItemController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemController/Edit/5
        [HttpGet("edit/{id}")]

        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ItemController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ItemController/Delete/5
        [HttpGet("Delete/{id}")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ItemController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
