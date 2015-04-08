using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vandrarhem.Models.Repository;
using VandrarhemDbAccess;

namespace Vandrarhem.Controllers
{
    public class HomeController : Controller
    {
        private VandrarhemSQLEntities db = new VandrarhemSQLEntities();
        private readonly IDbRepository _repository;

        public HomeController()
            : this(new DbRepository()) { }

        public HomeController(IDbRepository repository)
        {
            _repository = repository;
        }


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Kunder()
        //{
            
        //    return View(db.Kunds.ToList());
        //}

        //public ActionResult Bokningar()
        //{
        //    return View(db.Bokningars.ToList());
        //}

    }
}