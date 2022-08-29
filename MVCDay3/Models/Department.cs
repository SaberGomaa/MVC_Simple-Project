using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace MVCDay3.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Location { get; set; }
        public Department()
        {
            Students = new  List<Student>();
            Instractors = new List<Instractor>();
        }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Instractor> Instractors { get; set; }

    }
}