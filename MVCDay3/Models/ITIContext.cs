using System;
using System.Data.Entity;
using System.Linq;

namespace MVCDay3.Models
{
    public class ITIContext : DbContext
    {
        public ITIContext()
            : base("name=ITIContext")
        {
        }
        
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instractor> Instractors { get; set; }


    }

}