using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROLab.Models.DataModels
{
    public class Transaction
    {
        public int Id { get; set; }

        //Account
        [Display(Name = "Account")]
        public int? AccountId { get; set; }
        [Display(Name = "Account")]
        [ForeignKey("AccountId")]
        public Account Account { get; set; }

        //Transaction Description
        [Display(Name = "Description")]
        public string TransDescription { get; set; }

        //Transaction Amount
        [Display(Name ="Amount")]        
        public decimal Amount { get; set; }

        

    }
}
