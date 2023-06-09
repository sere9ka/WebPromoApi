﻿using System.ComponentModel.DataAnnotations;

namespace appserverproject.Data
{
    internal sealed class Promo
    {
        [Key]
        public int PromoId { get; set; }

        [Required]
        [MaxLength(50)]
        public string PromoTitle { get; set; } = string.Empty;

        public int PromoType { get; set; }

        public int PromoCurrency { get; set; }

        [Required]
        public DateTime PromoStart { get; set; }

        [Required]
        public DateTime PromoEnd { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Channel { get; set; } = string.Empty;

    }
}