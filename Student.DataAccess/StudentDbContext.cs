using Microsoft.EntityFrameworkCore;



namespace StudentFind.DataAccess
{
    public class StudentDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            
            optionsBuilder.UseSqlServer("Server=SY; Database=StudentDb; Integrated Security=true;"); //Bu bağlantı, kullanılacak olan veirtabanı bilgileri ile değiştirilmelidir.




        }

        public DbSet<StudentFind.Entities.Student> students { get; set; }

    }
}
