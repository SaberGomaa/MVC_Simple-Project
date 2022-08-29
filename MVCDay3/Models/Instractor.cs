using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDay3.Models
{
    public class Instractor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Hiredata { get; set; }

        [ForeignKey("Department")]
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }

    }
}