using System.ComponentModel.DataAnnotations;

namespace PROLab.DAIF2020.Models.DataModels
{
    public class Zone
    {
        public int Id { get; set; }

        [Display(Name = "Zone")]
        public string ZoneName { get; set; }
    }
}