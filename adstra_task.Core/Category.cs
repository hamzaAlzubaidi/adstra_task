using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace adstra_task.Core
{
   public class Category
    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Category Name")]
        [MaxLength(50,ErrorMessage = "The entry limit is 50 characters")]
        [MinLength(2,ErrorMessage = "You must enter at least two characters")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        //Navigtion
        public virtual List<AuthorPost> AuthorPosts { get; set; }
    }
}
