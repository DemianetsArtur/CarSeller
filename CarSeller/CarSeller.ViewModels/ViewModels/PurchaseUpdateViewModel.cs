﻿using System.ComponentModel.DataAnnotations;

namespace CarSeller.ViewModels.ViewModels
{
    public class PurchaseUpdateViewModel
    {
        [Required] public int Id { get; set; }

        [Required] public string UserId { get; set; }

        [Required] public int CarId { get; set; }
    }
}
