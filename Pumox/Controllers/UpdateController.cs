using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Pumox.Models;
using System.Net;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;

namespace Pumox.Controllers
{
    public class UpdateController : ApiController
    {
        private PumoxContext db = new PumoxContext();

        // PUT: company/update/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCompany(int id, Company company)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            company.Id = id;
            db.Company.AddOrUpdate(company);

            if (!CompanyExists(id))
            {
                return NotFound();
            }
            else
            {
                try
                {
                    await db.SaveChangesAsync();
                }
                catch (DbEntityValidationException)
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        private bool CompanyExists(int id)
        {
            return db.Company.Count(e => e.Id == id) > 0;
        }
    }
}