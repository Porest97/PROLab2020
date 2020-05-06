using System.ComponentModel.DataAnnotations;

namespace PROLab.NBS.Models.DataModels
{
    public class IncidentType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
        public string IncidentTypeName { get; set; }
    }
}