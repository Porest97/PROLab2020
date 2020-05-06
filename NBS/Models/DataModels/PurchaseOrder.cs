﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PROLab.NBS.Models.DataModels
{
    public class PurchaseOrder
    {
        public int Id { get; set; }

        [Display(Name = "PO #")]
        public string PONumber { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "PO Hours")]
        public decimal POHours { get; set; }

        public DateTime DateTimeApproved { get; set; }
    }
}