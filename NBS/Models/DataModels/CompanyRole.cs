using System.ComponentModel.DataAnnotations;

namespace PROLab.NBS.Models.DataModels
{
    public class CompanyRole
    {
        public int Id { get; set; }

        [Display(Name = "Role")]
        public string CompanyRoleName { get; set; }
    }
}