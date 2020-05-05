using System.ComponentModel.DataAnnotations;

namespace PROLab.DAIF2020.Models.DataModels
{
    public class SeriesStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string SeriesStatusName { get; set; }
    }
}