using JAG.DevTest2019.Host.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace JAG.DevTest2019.Host.Controllers
{
    public class LeadController : Controller
    {
        public ActionResult Index()
        {
            return View(new LeadViewModel());
        }

        public ActionResult SubmitLead(LeadViewModel model)
        {
            //TODO: 6. Call the WebAPI service here & pass results to UI

            LeadViewModel result = new LeadViewModel()
            {
                Results = new LeadResultViewModel()
                {
                    LeadId = new Random().Next(),
                    IsSuccessful = true,
                    Message = "Thank you for submitting your details"
                }
            };

            return View("Index",result);
        }
    }
}