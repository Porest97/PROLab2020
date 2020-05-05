using System.ComponentModel.DataAnnotations;

namespace PROLab.DAIF2020.Models.DataModels
{
    public class District
    {
        public int Id { get; set; }

        [Display(Name = "District")]
        public string DistrictName { get; set; }
    }
}