using Library_Model.Entities.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace Library_Access.Context
{
    public class LibraryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConStr = "Data Source=WIN-EFS54O4O7OC\\SQLEXPRESS;Initial Catalog=Library_Context;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(ConStr);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }


        public virtual DbSet<Author>? Authors { get; set; }
        public virtual DbSet<Book>? Books { get; set; }
        public virtual DbSet<Category>? Categories { get; set; }
        public virtual DbSet<Group>? Groups { get; set; }
        public virtual DbSet<S_Card>? S_Cards { get; set; }
        public virtual DbSet<Student>? Students { get; set; }
        public virtual DbSet<T_Card>? T_Cards { get; set; }
        public virtual DbSet<Teacher>? Teachers { get; set; }
    }
}
