using PROLab.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROLab.Models.ViewModels
{
    public class ACCViewModel
    {
        public List<Account> Accounts { get; internal set; }

        public List<Transaction> Transactions { get; internal set; }
    }
}
