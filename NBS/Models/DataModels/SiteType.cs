using System.ComponentModel.DataAnnotations;

namespace PROLab.NBS.Models.DataModels
{
    public class SiteType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string SiteTypeName { get; set; }
    }
}