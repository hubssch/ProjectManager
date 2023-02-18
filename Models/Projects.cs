using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ProjectManager.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        [BindRequired]
        [Required(ErrorMessage = "Select categiry")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [BindRequired]
        [Required(ErrorMessage = "Select emplyee")]
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
