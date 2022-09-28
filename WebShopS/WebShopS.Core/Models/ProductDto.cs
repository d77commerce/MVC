using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebShopS.Core.Models
{
    /// <summary>
    /// view moddel
    /// </summary>
    public class ProductDto
    {
       
            /// <summary>
            /// product identifier
            /// </summary>
            public Guid Id { get; set; }

            /// <summary>
            /// product name
            /// </summary>
            [Required]
            [StringLength(50)]
            public string Name { get; set; } = null!;

            /// <summary>
            /// product price
            /// </summary>
            [Range(typeof(decimal), "0.1", "5000", ConvertValueInInvariantCulture = true)]
            public decimal Price { get; set; }
            /// <summary>
            /// product Qty
            /// </summary>
            [Required]
            [Range(1, int.MaxValue)]
            public int Quantity { get; set; }

            /// <summary>
            /// product descriptionId
            /// </summary>
            [StringLength(150)]
            public string Description { get; set; } = null!;

            /// <summary>
            /// product Barcode
            /// </summary>
            [Required]
            [StringLength(15)]
            public string BarCode { get; set; } = null!;

        }
    }

