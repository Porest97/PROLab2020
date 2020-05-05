using System.ComponentModel.DataAnnotations;

namespace PROLab.DAIF2020.Models.DataModels
{
    public class GameStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string GameStatusName { get; set; }
    }
}