using MVC_Practical_11.DAL;
using MVC_Practical_11.Data;
using MVC_Practical_11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practical_11.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserDataAccess _userDataAccess;

        public HomeController(IUserDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;
        }

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {   
            return View(_userDataAccess.GetUsers());
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var user = _userDataAccess.GetUser(id);
            if (user != null)
            {
                return View(user);
            }

            return View("Error");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = _userDataAccess.GetUser(id);
            if (user != null)
            {
                return View(user);
            }

            return View("Error");
        }

        [HttpPost]
        public ActionResult Edit(int id,User user)
        {
            var isEdit  = _userDataAccess.UpdateUser(id,user);
            if (isEdit)
            {
                return RedirectToAction("Index");
            }
            return View("Error");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var user = _userDataAccess.GetUser(id);
            if (user != null)
            {
                return View(user);
            }

            return View("Error");
        }

        [HttpPost]
        public ActionResult Delete(int id,User user1)
        {
            var user = _userDataAccess.DeleteUser(id);
            if (user)
            {
                return RedirectToAction("Index");
            }

            return View("Error");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            int id = _userDataAccess.GetUsers().Count + 1;
            user.Id = id;
            _userDataAccess.CreateUser(user);

            return RedirectToAction("Index");
        }
        
    }
}