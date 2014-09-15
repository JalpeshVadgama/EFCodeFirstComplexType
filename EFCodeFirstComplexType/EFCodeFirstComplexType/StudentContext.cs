using System.Data.Entity;

namespace EFCodeFirstComplexType
{
    
    public class StudentContext : DbContext
    {
        public StudentContext()
            : base("DefaultConnectionString")
        {
            
        }
        public DbSet<Student> Students { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.ComplexType<Address>();
        //}
    }
}