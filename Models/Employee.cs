//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        [Required]
        [Display(Name = "E_id", ResourceType = typeof(Resource.EmployeeResource))]
        public int? E_id { get; set; }

        [Display(Name = "E_name", ResourceType = typeof(Resource.EmployeeResource))]
        public string E_name { get; set; }

        [Display(Name = "E_name", ResourceType = typeof(Resource.EmployeeResource))]
        public string E_address { get; set; }

        [Display(Name = "E_tel", ResourceType = typeof(Resource.EmployeeResource))]
        public int? E_tel { get; set; }

        [Display(Name = "E_Email", ResourceType = typeof(Resource.EmployeeResource))]
        public string E_Email { get; set; }

        [Display(Name = "E_User", ResourceType = typeof(Resource.EmployeeResource))]
        public string E_User { get; set; }

        [Display(Name = "E_pwd", ResourceType = typeof(Resource.EmployeeResource))]
        public string E_pwd { get; set; }
    }
}
