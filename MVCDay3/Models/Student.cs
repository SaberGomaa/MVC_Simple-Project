using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDay3.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        [ForeignKey("department")]
        public int DeptId { get; set; }
        public virtual Department department { get; set; }
    }
}