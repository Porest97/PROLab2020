using System.ComponentModel.DataAnnotations;

namespace PROLab.NBS.Models.DataModels
{
    public class CompanyStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string CompanyStatusName { get; set; }
    }
}