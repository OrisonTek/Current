using JAG.DevTest2019.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace JAG.DevTest2019.LeadService.Controllers
{
    public class LeadController : ApiController
    {
        [HttpPost]
        [ResponseType (typeof(LeadResponse))]
        public HttpResponseMessage Post(Lead request)
        {
            LeadResponse response = new LeadResponse()
            {
                LeadId = 10000000 + new Random().Next(),
                IsCapped = false,
                Messages = new[] { "Success from WebAPI" },
                IsSuccessful = true,
                IsDuplicate = false
            };

            //TODO: 7. Write the lead to the DB
            
            Console.WriteLine($"Lead received {request.FirstName} {request.Surname}");

            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}
