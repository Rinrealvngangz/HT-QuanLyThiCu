using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eManagerSystem.Data.Entities;


namespace eManagerSystem.Data.EF
{
   public  class eManagerSystemDbContext : DbContext
    {
     
        public eManagerSystemDbContext() :base("StudentDBConnectString")
        {
          
          Database.SetInitializer<eManagerSystemDbContext>(new CreateDatabaseIfNotExists<eManagerSystemDbContext>());
        }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(s => s.FirstName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Student>()
                .Property(s => s.LastName).HasMaxLength(100);
            modelBuilder.Entity<Student>()
                .HasRequired<Grade>(s => s.Grade)
                .WithMany(g => g.Students)
                .HasForeignKey<int>(s => s.CurrentGradeId);

            modelBuilder.Entity<Student>()
                 .HasRequired<Subject>(sb => sb.Subject)
                 .WithMany(sb => sb.Students)
                 .HasForeignKey(s => s.CurrentSubjectId);
           

        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Grade> Grades { get; set; }

        public DbSet<Subject> Subjects { get; set; }
    }
}
