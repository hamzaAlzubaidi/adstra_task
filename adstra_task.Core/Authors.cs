using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace adstra_task.Core
{
   public  class Authors
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [Display(Name ="User Id")]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "User Name ")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string  FullName  { get; set; }
        [Required]
        [Display(Name = "Profile Picture Url")]
        public string ProfileImageUrl { get; set; }
        public string Bio { get; set; }
        public string FaceBook { get; set; }
        public string Instgram { get; set; }
        public string Twitter { get; set; }
        //Navigtion
        public virtual List<AuthorPost> AuthorPosts { get; set; }


    }
}
