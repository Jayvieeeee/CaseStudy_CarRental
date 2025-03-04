﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;

namespace CarRental.Models
{
    public class RentalRequest
    {
            [Key]
            public int RequestId { get; set; }

            [ForeignKey("Renters")]
            public int RenterId { get; set; }

            [ForeignKey("Car")]
            public int CarId { get; set; }

            public DateTime RentalDate { get; set; }
            public DateTime ReturnDate { get; set; }

            [Column(TypeName = "decimal(18,2)")]
            public decimal EstimatedPrice { get; set; }

            public string Status { get; set; } // "Pending", "Approved", "Rejected"

            public Renters Renters { get; set; }
            public Cars Car { get; set; }
    }
}
