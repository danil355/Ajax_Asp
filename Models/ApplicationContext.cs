using System.Data.Entity;

namespace AjaxProject.Models
{
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }

        public ApplicationContext() : base("name=DefaultConnection")
        {
            
        }
    }
}