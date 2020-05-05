using System.ComponentModel.DataAnnotations;

namespace PROLab.DAIF2020.Models.DataModels
{
    public class ArenaStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string ArenaStatusName { get; set; }
    }
}