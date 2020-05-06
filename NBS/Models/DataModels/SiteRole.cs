using System.ComponentModel.DataAnnotations;

namespace PROLab.NBS.Models.DataModels
{
    public class SiteRole
    {
        public int Id { get; set; }

        [Display(Name = "Role")]
        public string SiteRoleName { get; set; }
    }
}