using Hamburg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Hamburg.ViewModel.Default;
using System.Web;
using System.Web.Mvc;

namespace Hamburg.Controllers
{
    public class HomeController : Controller
    {
        HamburgEntities db = new HamburgEntities();
        public ActionResult Index()
        {
            var defaultModel = new DefaultViewModel
            {
                homeTitle = db.HomeTitles.FirstOrDefault(),
                homeCountry = db.HomeCountries.ToList(),
                contactPage=db.Contacts.FirstOrDefault()
            };
            return View(defaultModel);
        }

        public ActionResult About()
        {
            var defaultModel = new DefaultViewModel
            {
                aboutTitle = db.AboutTitles.FirstOrDefault(),
                aboutOneList=db.AboutOnes.ToList(),
                aboutTwoList=db.AboutTwoes.FirstOrDefault(),
                contactPage = db.Contacts.FirstOrDefault()
            };

            return View(defaultModel);
        }

        public ActionResult Contact()
        {
            var defaultModel = new DefaultViewModel
            {
                
                contactPage = db.Contacts.FirstOrDefault()
            };

            return View(defaultModel);
        }
        public ActionResult Gallery()
        {
            var defaultModel = new DefaultViewModel
            {
                galleryImg = db.Galleries.ToList(),
            };
            return View(defaultModel);
        }
    }
}