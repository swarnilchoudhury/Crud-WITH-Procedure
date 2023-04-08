using CrudProcedure.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CRUDwithProcedure.Controllers
{

    public class EmployeeController : Controller
    {
        PracticeDbEntities2 PracticeDb2 = new PracticeDbEntities2();

        public ActionResult Index()
        {
            var display = PracticeDb2.SP_Display_Emp();

            return View(display.ToList());
        }


        public ActionResult Details(int? id)
        {
            try
            {

                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Bad Request");
                }

                SqlParameter param = new SqlParameter("@Empid", id);
                var data = PracticeDb2.Database.SqlQuery<tblEmployeeProcedure>("EXEC SP_Details_Emp @Empid", param).SingleOrDefault();

                if (data == null)
                {
                    return View("NotFound");
                }

                return View(data);
            }
            catch (Exception)
            {
                return View("Error");
            }

        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(tblEmployeeProcedure collection)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {

                SqlParameter param = new SqlParameter("@EmpName", collection.Empname);
                SqlParameter param2 = new SqlParameter("@City", collection.City);
                SqlParameter param3 = new SqlParameter("@Gender", collection.Gender);
                SqlParameter param4 = new SqlParameter("@Email", collection.Email);
                var data = PracticeDb2.Database.ExecuteSqlCommand("SP_Create_Emp @EmpName,@City,@Gender,@Email", param, param2, param3, param4);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return View("Error");
            }
        }


        public ActionResult Edit(int id)
        {
            SqlParameter param = new SqlParameter("@Empid", id);
            var data = PracticeDb2.Database.SqlQuery<tblEmployeeProcedure>("EXEC SP_Details_Emp @Empid", param).SingleOrDefault();
            return View(data);

        }


        [HttpPost]
        public ActionResult Edit(int id, tblEmployeeProcedure collection)
        {
            try
            {
                SqlParameter param = new SqlParameter("@EmpName", collection.Empname);
                SqlParameter param2 = new SqlParameter("@City", collection.City);
                SqlParameter param3 = new SqlParameter("@Gender", collection.Gender);
                SqlParameter param4 = new SqlParameter("@Email", collection.Email);
                var data = PracticeDb2.Database.ExecuteSqlCommand("SP_Edit_Emp @EmpName,@City,@Gender,@Email", param, param2, param3, param4);
                return RedirectToAction("Index");



            }
            catch (Exception)
            {
                return View("Error");
            }
        }


        public ActionResult Delete(int id)
        {
            SqlParameter param = new SqlParameter("@Empid", id);
            var data = PracticeDb2.Database.SqlQuery<tblEmployeeProcedure>("EXEC SP_Details_Emp @Empid", param).SingleOrDefault();
            return View(data);

        }


        [HttpPost]
        public ActionResult Delete(int id, tblEmployeeProcedure collection)
        {
            try
            {
                SqlParameter param = new SqlParameter("@Empid", id);
                PracticeDb2.Database.ExecuteSqlCommand("SP_Delete_Emp @Empid", param);
                return RedirectToAction("Index");



            }
            catch (Exception)
            {
                return View("Error");
                

            }
        }
    }
}
