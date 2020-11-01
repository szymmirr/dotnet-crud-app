using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Pumox.Models;
using System.Linq;

namespace Pumox.Controllers
{
    public class DeleteController : ApiController
    {
        private PumoxContext db = new PumoxContext();

        // DELETE: company/delete/5
        [ResponseType(typeof(Company))]
        public async Task<IHttpActionResult> DeleteCompany(int id)
        {
            Company company = await db.Company.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            db.Company.Remove(company);
            await db.SaveChangesAsync();

            return Ok("Deleted entry of id " + id);
        }
    }
}