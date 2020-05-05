using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PROLab.Models.DataModels
{
    public class Account
    {
        public int Id { get; set; }

        

        [Display(Name = "Account #")]
        public string AccountNumber { get; set; }

        //Owner Identity
        [Display(Name = "Owner")]
        public int? PersonId { get; set; }
        [Display(Name = "Owner")]
        [ForeignKey("PersonId")]
        public Person AccountOwner { get; set; }

        //Account Description
        [Display(Name = "Description")]
        public string AccountDescription { get; set; }

        //Add props for Debit/Credit/Balance

        [Display(Name = "Balance")]
        public decimal Balance { get; set; }


        //Concatination ACCPlusACCOwner
        [Display(Name = "Account")]
        public string AccPlusOwner { get { return string.Format("{0} {1} ", AccountNumber, AccountDescription ); } }



        //Add List of Transactions to account !


    }
}
