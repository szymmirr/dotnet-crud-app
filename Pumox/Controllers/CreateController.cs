using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Pumox.Models;

namespace Pumox.Controllers
{
    public class CreateController : ApiController
    {
        private PumoxContext db = new PumoxContext();

        // POST: company/create
        [ResponseType(typeof(Create))]
        public async Task<IHttpActionResult> PostCreate(Company company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Company.Add(company);
            await db.SaveChangesAsync();

            var companyCustom = new
            {
                Id = company.Id
            };

            return CreatedAtRoute("DefaultApi", new { id = company.Id }, companyCustom);
        }
    }
}