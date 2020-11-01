using System.Linq;
using System.Web.Http;
using System.Web.Http.Description;
using Pumox.Models;

namespace Pumox.Controllers
{
    public class SearchController : ApiController
    {
        private PumoxContext db = new PumoxContext();

        // POST: company/search
        [ResponseType(typeof(Company))]
        [AllowAnonymous]
        public IQueryable<Company> SearchCompany(Search search)
        {
            var query =
                from company in db.Company
                join employee in db.Employee on company.Id equals employee.CompanyId
                where company.Name == search.Keyword
                || employee.FirstName == search.Keyword
                || employee.LastName == search.Keyword
                || employee.JobTitle == search.JobTitle
                || employee.FirstName == search.Keyword
                || (employee.DateOfBirth >= search.EmployeeDateOfBirthFrom && employee.DateOfBirth <= search.EmployeeDateOfBirthTo)
                select company;

            // Eager loading
            foreach (var result in query)
            {
                db.Company.Attach(result);
                db.Entry(result).Collection(a => a.Employees).Load();
            }

            return query;
        }
    }
}