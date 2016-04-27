

using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AuthenticaEmployee.Models;
using AutoMapper;

namespace AuthenticaEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _empService;

        public EmployeeController(EmployeeService empService)
        {
            _empService = empService;
        }

        // GET: Employee
        public ActionResult Index()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                return View();
            }
            return Redirect("/Account/Login");
        }

        //Returns JSON List of all Employees
        public ActionResult GetEmployees()
        {
            var employeeList = Mapper.Map<List<EmployeeModel>, List<EmployeeViewModel>>(_empService.GetEmployees().ToList());
            return Json(employeeList, JsonRequestBehavior.AllowGet);
            //return Json(_empService.GetEmployees().ToList());
        }

        //Uses EmployeeService to remove all employees from Db
        public ActionResult RemoveEmployees()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
                _empService.EmptyTable();
            return RedirectToAction("Index", "Employee");
        }

        //Uses EmployeeService to add test data to Db
        public ActionResult AddEmployees()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
                _empService.AddEmployees();
            return RedirectToAction("Index", "Employee");
        }
    }
}