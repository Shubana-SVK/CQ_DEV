using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductSearch.Models;

namespace ProductSearch.Controllers
{
    public class ProductsController : Controller
    {
        ProductsDBContext dbContext = new ProductsDBContext();

        // GET: Products
        public ActionResult Index(string platform, string exchCd, string options, string search)
        {
            ViewBag.Platform = (from r in dbContext.Platforms
                                select r.Platform_Desc).Distinct();

            ViewBag.ExchCd = (from r in dbContext.Contracts
                                select r.Exch_Cd).Distinct();

            ViewBag.ComCd = (from r in dbContext.Contracts
                              select r.Com_Cd).Distinct();

            if ((platform != "" || exchCd != "" || platform != null || exchCd != null) && (options == null))
            {
                if (platform != "")
                {
                    if (search == "")
                        return View(dbContext.Products.Where(x => x.PlatformDesc.Contains(platform)).ToList());
                    else
                        return View(dbContext.Products.Where(x => x.PlatformDesc.Contains(search) || search == null).ToList());
                }
                else
                {
                    if (search == "")
                        return View(dbContext.Products.Where(x => x.PlatformDesc.Contains(exchCd)).ToList());
                    else
                        return View(dbContext.Products.Where(x => x.PlatformDesc.Contains(search) || search == null).ToList());
                }
            }
            else if (options != null)
            {
                if (options == "PlatformDesc")
                {
                    //Index action method will return a view with a student records based on what a user specify the value in textbox  
                    return View(dbContext.Products.Where(x => x.PlatformDesc.Contains(search) || search == null).ToList());
                }
                else if (options == "ExchCd")
                {
                    return View(dbContext.Products.Where(x => x.ExchCd.Contains(search) || search == null).ToList());
                }
                else if (options == "ComCd")
                {
                    return View(dbContext.Products.Where(x => x.ComCD.Contains(search) || search == null).ToList());
                }
                else
                {
                    return View(dbContext.Products.ToList());
                }
            }
            else
            {
                return View(dbContext.Products.ToList());
            }
            //List<Product> productList = dbContext.Products.ToList();
            //return View(productList);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
