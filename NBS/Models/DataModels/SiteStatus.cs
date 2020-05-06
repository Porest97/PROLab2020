using System.ComponentModel.DataAnnotations;

namespace PROLab.NBS.Models.DataModels
{
    public class SiteStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string SiteStatusName { get; set; }
    }
}