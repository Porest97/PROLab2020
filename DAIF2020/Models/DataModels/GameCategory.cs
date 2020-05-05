using System.ComponentModel.DataAnnotations;

namespace PROLab.DAIF2020.Models.DataModels
{
    public class GameCategory
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string GameCategoryName { get; set; }
    }
}