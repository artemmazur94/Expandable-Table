using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1
{
    public class DataContext: DbContext
    {
        public DbSet<SomeModel> Models { get; set; }

        public DataContext() : base("DataContext")
        {
            Database.SetInitializer(new DataContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class DataContextInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            
            base.Seed(context);
        }
    }
}