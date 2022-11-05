using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Infrastructure.Dto
{
    public class Category
    {
        public Category()
        {
            Houses = new List<House>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        public List<House> Houses { get; set; }
    }
    //    •	Id – a unique integer, Primary Key
    //•	Name – a string with max length 50 (required)
    //•	Houses – a collection of House

}
