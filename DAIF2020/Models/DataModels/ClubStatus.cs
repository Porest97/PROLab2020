using System.ComponentModel.DataAnnotations;

namespace PROLab.DAIF2020.Models.DataModels
{
    public class ClubStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string ClubStatusName { get; set; }
    }
}