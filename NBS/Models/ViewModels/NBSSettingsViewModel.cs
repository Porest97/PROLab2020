using PROLab.NBS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROLab.NBS.Models.ViewModels
{
    public class NBSSettingsViewModel
    {

        //Company Settings
        public List<CompanyRole> CompanyRoles { get; internal set; }

        public List<CompanyStatus> CompanyStatuses { get; internal set; }

        public List<CompanyType> CompanyTypes { get; internal set; }

        //Incident Settings
        public List<IncidentPriority> IncidentPriorities { get; internal set; }

        public List<IncidentStatus> IncidentStatuses { get; internal set; }

        public List<IncidentType> IncidentTypes { get; internal set; }

        //Site Settings
        public List<SiteRole> SiteRoles { get; internal set; }

        public List<SiteStatus> SiteStatuses { get; internal set; }

        public List<SiteType> SiteTypes { get; internal set; }


        //Preallocated strings of code ;)

        //public List<> Roles { get; internal set; }

        //public List<> Statuses { get; internal set; }

        //public List<> Types { get; internal set; }

       
    }
}
