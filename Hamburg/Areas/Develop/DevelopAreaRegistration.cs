using System.Web.Mvc;

namespace Hamburg.Areas.Develop
{
    public class DevelopAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Develop";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Develop_default",
                "Develop/{controller}/{action}/{id}",
                new { controller = "HomeTitles", action = "Index", id = UrlParameter.Optional },
                new string[] { "Hamburg.Areas.Develop.Controllers" }
            );
        }
    }
}