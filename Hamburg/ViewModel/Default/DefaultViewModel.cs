using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hamburg.Models;

namespace Hamburg.ViewModel.Default
{
    public class DefaultViewModel
    {
        public HomeTitle homeTitle { get; set; }
        public List<HomeCountry> homeCountry { get; set; }
        public Contact contactPage { get; set; }
        public AboutTitle aboutTitle { get; set; }
        public List<AboutOne> aboutOneList { get; set; }
        public AboutTwo aboutTwoList { get; set; }
        public List<Gallery> galleryImg { get; set; }

    }
}