using PROLab.NBS.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROLab.NBS.Models.ViewModels
{
    public class NBSDataViewModel
    {
        public List<Company> Companies { get; internal set; }

        public List<Incident> Incidents { get; internal set; }

        public List<PurchaseOrder> PurchaseOrders { get; internal set; }

        public List<Site> Sites { get; internal set; }
    }
}
