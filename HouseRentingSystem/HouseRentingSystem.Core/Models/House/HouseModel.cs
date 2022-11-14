using HouseRentingSystem.Infrastructure.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Core.Models.House
{
    public class HouseModel
    {
        [Required]
        [StringLength(50,MinimumLength =10)]
        public string Title { get; set; } = null!;
        [Required]
        [StringLength(150,MinimumLength =30)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(500, MinimumLength = 50)]
        public string Description { get; set; } = null!;

        [Required]
        [Display(Name = "Img URL")]
        public string ImgURL { get; set; } = null!;

        [Required]
        [Display(Name = "Price per Mount")]
        [Range(0.00, 2000.00, ErrorMessage = "Price per mant be a positive number")]
        public decimal PricePerMount { get; set; }

        [Display(Name ="Category")]
        public int  CategoryId { get; set; }

        public IEnumerable<HouseCategoryModel> HouseCategoryModel { get; set; } = new List<HouseCategoryModel>();
    }
}
