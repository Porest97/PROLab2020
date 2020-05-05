using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROLab.Models.DataModels
{
    public class PhysicalSampling
    {
        public int Id { get; set; }

        [Display(Name ="Time of Sampling")]
        public DateTime DateTimeSampleTaken { get; set; }
        [Display(Name = "Blood Pressure")]
        public string BloodPressure { get; set; }

        [Display(Name = "Oxygenation")]
        public string Oxygenation { get; set; }

        [Display(Name = "Body Temp in C")]
        public decimal BodyTemperature { get; set; }

        [Display(Name = "Comment")]
        public string Comment { get; set; }
    }
}
