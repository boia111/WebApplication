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
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            using (DBModel db = new DBModel())
            {
                return View(db.Employees.ToList());
            }

        }

        // GET: Employee/Details/5
        public ActionResult Details(int? id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.Employees.Where(x => x.E_id == id).FirstOrDefault());
            }

        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBModel db = new DBModel())
                {
                    db.Employees.Add(emp);
                    db.SaveChanges();

                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = ex.Message.ToString() });
                //return Json(new { Success = false, Message = ex.Message });
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.Employees.Where(x => x.E_id == id).FirstOrDefault());
            }
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int? id, Employee emp)
        {
            try
            {
              
                // TODO: Add update logic here

                using (DBModel db = new DBModel())
                {
                    if (emp != null)
                    {
                        db.Entry(emp).State = EntityState.Modified;
                        //db.Employees.Add(emp);
                        db.SaveChanges();
                    }
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = ex.Message.ToString() });
                //return Json(new { Success = false, Message = ex.Message } );
            }
           
        }

        //  GET: Employee/Delete/5
        public ActionResult Delete(int? id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.Employees.Where(x => x.E_id == id).FirstOrDefault());
            }

        }

        //  POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, Employee emp)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModel db = new DBModel())
                {
                    if (id >= 0)
                    {
                        var empid = db.Employees.Where(x => x.E_id == id).FirstOrDefault();
                        if (empid != null)
                        {
                            db.Entry(empid).State = EntityState.Deleted;
                            db.SaveChanges();
                        }
                    }
                }

                return RedirectToAction("Index");
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                return View("Delete");
            }
        }

        [HttpPost]
        public ActionResult GetList()
        {
            //Server Side Parameter
            int start = Convert.ToInt32(Request["start"]);
            int length = Convert.ToInt32(Request["length"]);
            string searchValue = Request["search[value]"];
            string sortColumnName = Request["columns[" + Request["order[0][column]"] + "][name]"];
            string sortDirection = Request["order[0][dir]"];

            List<Employee> empList = new List<Employee>();
            try
            {
                using (DBModel db = new DBModel())
                {
                    empList = db.Employees.ToList<Employee>();
                    int totalrows = empList.Count;
                    if (!string.IsNullOrEmpty(searchValue))//filter
                    {
                        empList = empList.
                        Where(x => x.E_id.ToString().Contains(searchValue.ToLower()) || x.E_name.ToLower().Contains(searchValue.ToLower()) || x.E_address.ToLower().Contains(searchValue.ToLower()) || x.E_tel.ToString().Contains(searchValue.ToLower()) || x.E_Email.ToLower().Contains(searchValue.ToLower()) || x.E_Email.ToLower().Contains(searchValue.ToLower())).ToList<Employee>();
                    }
                    int totalrowsafterfiltering = empList.Count;
                    //sorting
                    empList = empList.OrderBy(sortColumnName + " " + sortDirection).ToList<Employee>();

                    //paging
                    empList = empList.Skip(start).Take(length).ToList<Employee>();


                    return Json(new { data = empList, draw = Request["draw"], recordsTotal = totalrows, recordsFiltered = totalrowsafterfiltering }, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                Response.StatusCode = 500;
                return Json(new { error = ex.Message.ToString() });
                //return Json(new { Success = false, Message = ex.Message });
            }
        }
    }
}
