using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Linq.Dynamic;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        
        }
        public ActionResult Index1()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Index(Customer cus)
        {
            try
            {
                // add insert logic 
                using (DBModel db = new DBModel())
                {
                    db.Customers.Add(cus);
                    db.SaveChanges();
                    
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = ex.Message.ToString() });
            }
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
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

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
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

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
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

        //[HttpPost]
        //public ActionResult GetList()
        //{
        //    //Server Side Parameter
        //    int start = Convert.ToInt32(Request["start"]);
        //    int length = Convert.ToInt32(Request["length"]);
        //    string searchValue = Request["search[value]"];
        //    string sortColumnName = Request["columns[" + Request["order[0][column]"] + "][name]"];
        //    string sortDirection = Request["order[0][dir]"];

        //    List<Customer> CusList = new List<Customer>();
        //    try
        //    {
        //        using (DBModel db = new DBModel())
        //        {
        //            CusList = db.Customers.ToList<Customer>();
        //            int totalrows = CusList.Count;
        //            if (!string.IsNullOrEmpty(searchValue))//filter
        //            {
        //                CusList = CusList.
        //                Where(x => x.C_id.ToString().Contains(searchValue.ToLower()) || x.C_name.ToLower().Contains(searchValue.ToLower()) || x.C_pwd.ToLower().Contains(searchValue.ToLower()) || x.C_pwd.ToString().Contains(searchValue.ToLower()) || x.C_sex.ToLower().Contains(searchValue.ToLower()) || x.C_tel.ToString().Contains(searchValue.ToLower())).ToList<Customer>();
        //            }
        //            int totalrowsafterfiltering = CusList.Count;
        //            //sorting
        //            CusList = CusList.OrderBy(sortColumnName + " " + sortDirection).ToList<Customer>();

        //            //paging
        //            CusList = CusList.Skip(start).Take(length).ToList<Customer>();


        //            return Json(new { data = CusList, draw = Request["draw"], recordsTotal = totalrows, recordsFiltered = totalrowsafterfiltering }, JsonRequestBehavior.AllowGet);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.StatusCode = 500;
        //        return Json(new { error = ex.Message.ToString() });
        //        //return Json(new { Success = false, Message = ex.Message });
        //    }
        //}
    }
}
