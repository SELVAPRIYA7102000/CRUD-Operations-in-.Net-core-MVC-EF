using EFPT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SampleCore.Core.IServices;
using SampleCore.Core.Model;
using SampleCore.Entity;
using System.Diagnostics;

namespace EFPT.Controllers
{
    public class HomeController : Controller
    {

       
        private readonly IPersonServices _PersonServices;
        public HomeController (IPersonServices services)
        {
            
            _PersonServices = services;
        }
        #region   Create table


        [HttpGet]

        public IActionResult login()

        {

            PersonLogin loginModel = new PersonLogin();

            return View(loginModel);

        }

        [HttpPost]

        public IActionResult login(PersonLogin loginModel)

        {
            PersonDBContext testDBContext = new PersonDBContext();
            var staff = testDBContext.Login.Where(m => m.UserName == loginModel.Name && m.Password == loginModel.Password).FirstOrDefault();

            if (staff != null)

            {

                return RedirectToAction("Index");
            }

            else

            {

                ViewBag.Message = "Invalid login detail.";

            }

            return View(loginModel);

        }




        public IActionResult Index()
        {
            var list = new List<string>() { "CSE", "IT", "ECE", "EEE", "MECH", "AI", "CIVIL" };
            ViewBag.list = list;
            return View();
           
        }

        [HttpPost]
        public IActionResult Index(Person data)
        {
                _PersonServices.CreatePersonEntry(data);

                return RedirectToAction("Read");
  
        }
       
        #endregion

        #region Read data from table
        public IActionResult Read()
        {
            var value = _PersonServices.Reads();
            return View(value);

        }
        #endregion

        #region Edit data
        public IActionResult Edit(int id)
        {
            var value= _PersonServices.EditForm(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Edit(int id, Person model)
        {
            _PersonServices.Update(id, model);
            return RedirectToAction("Read");
        }

        #endregion

        #region Delete 
        public IActionResult Delete(int person_id)
        {
            _PersonServices.Delete(person_id);
            return RedirectToAction("Read");
        }


        #endregion

       
    }
}