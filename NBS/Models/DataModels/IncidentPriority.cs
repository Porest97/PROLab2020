using System.ComponentModel.DataAnnotations;

namespace PROLab.NBS.Models.DataModels
{
    public class IncidentPriority
    {
        public int Id { get; set; }

        [Display(Name = "Prio.")]
        public string IncidentPriorityName { get; set; }
    }
}