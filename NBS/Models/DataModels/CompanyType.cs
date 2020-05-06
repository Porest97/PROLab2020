using System.ComponentModel.DataAnnotations;

namespace PROLab.NBS.Models.DataModels
{
    public class CompanyType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string CompanyTypeName { get; set; }
    }
}