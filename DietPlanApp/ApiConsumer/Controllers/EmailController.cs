using DietPlanApp.ApiConsumer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace DietPlanApp.ApiConsumer.Controllers
{
    public class EmailController : ApiController
    {
        // GET: api/Email
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Email/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Email
        [ResponseType(typeof(EmailApiModel))]
        public IHttpActionResult PostPerformance(EmailApiModel emailApiModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //var service = new EmailService();
            //service.SendEmail(emailApiModel);


            return Ok();
        }

        // PUT: api/Email/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Email/5
        public void Delete(int id)
        {
        }
    }

}