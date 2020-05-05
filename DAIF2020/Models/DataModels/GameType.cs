using System.ComponentModel.DataAnnotations;

namespace PROLab.DAIF2020.Models.DataModels
{
    public class GameType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string GameTypeName { get; set; }
    }
}