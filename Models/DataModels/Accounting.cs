using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROLab.Models.DataModels
{
    public class Accounting
    {

        public int Id { get; set; }
        // Account
        [Display(Name = "Account")]
        public int? AccountId { get; set; }
        [Display(Name = "Account")]
        [ForeignKey("AccountId")]
        public Account Account { get; set; }

        //Transaction
        [Display(Name = "Trans")]
        public int? TransactionId { get; set; }
        [Display(Name = "Trans")]
        [ForeignKey("TransactionId")]
        public Transaction Transaction { get; set; }

        public string ReferensNumber { get; set; }

        
    }
}
