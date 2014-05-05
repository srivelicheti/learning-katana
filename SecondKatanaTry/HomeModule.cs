using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondKatanaTry
{
    public class HomeModule:NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                var model = new { title = "We'hve got issues." };
                return View["home",model];
            };
        }
    }
}