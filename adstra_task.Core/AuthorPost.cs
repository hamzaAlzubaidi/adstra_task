using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace adstra_task.Core
{
    public class AuthorPost
    {
        public object Author;

        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name = "User Id")]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "User Name ")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Post Category  ")]
        [DataType(DataType.Text)]
        public string postCategory { get; set; }
        [Required]
        [Display(Name = "Post Title")]
        [DataType(DataType.Text)]
        public string PostTitle { get; set; }
        [Required]
        [Display(Name = "Post Descraption")]
        [DataType(DataType.MultilineText)]
        public string PostDescraption { get; set; }
        [Required]
        [Display(Name = "Profile Picture Url")]
        [DataType(DataType.Upload)]
        public string PostImageUrl { get; set; }
        [Required]
        [Display(Name = "Added Date")]
        public DateTime AddedDate { get; set; }


        //Navigtion Area
        public int AuthorId { get; set; }
        public Authors Authors { get; set; }

        public int CategoryId { get; set; }
        public Category category { get; set; }


    }
}
