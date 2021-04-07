using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Models
{
    public class EmployeeModel : BaseModel
    {
        

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [StringLength(10)]
        public string Mobile { get; set; }
        [Required]
        [StringLength(10)]
        public string City { get; set; }
        [Required]
        public string Department { get; set; }
    }
}
