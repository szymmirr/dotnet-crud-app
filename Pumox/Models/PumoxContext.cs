using System.Data.Entity;

namespace Pumox.Models
{
    public class PumoxContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PumoxContext() : base("name=PumoxContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public System.Data.Entity.DbSet<Pumox.Models.Company> Company { get; set; }

        public System.Data.Entity.DbSet<Pumox.Models.Employee> Employee { get; set; }

        public System.Data.Entity.DbSet<Pumox.Models.Search> Search { get; set; }

        public System.Data.Entity.DbSet<Pumox.Models.Create> Create { get; set; }

        public System.Data.Entity.DbSet<Pumox.Models.Update> Update { get; set; }

        public System.Data.Entity.DbSet<Pumox.Models.Delete> Delete { get; set; }
    }
}
