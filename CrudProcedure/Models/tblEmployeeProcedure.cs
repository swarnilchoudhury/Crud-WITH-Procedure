//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudProcedure.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblEmployeeProcedure
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(maximumLength: 20, MinimumLength = 5, ErrorMessage = "Must enter name between 5 and 20")]
        [Display(Name = "Employee Name")]
        public string Empname { get; set; }

        [Required(ErrorMessage = "City is required")]
       
        public string City { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(".+@.+\\..+",ErrorMessage ="Email id is invalid")]
        public string Email { get; set; }
    }
}
