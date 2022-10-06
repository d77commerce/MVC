using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static  ForumApp.Data.DataConstants.Post;


namespace ForumApp.Data.Models
{
    [Comment("Published posts")]
    public class Post
    {
        [Comment("Post Identifier")]
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("Title")]
        [MaxLength(TitleMaxPost)]
        public string Title { get; set; } = null!;

        [Required]
        [Comment("Content")]
        [MaxLength(ContentMaxPost)]
        public string Content { get; set; } = null!;
    }
}
