﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconLMS.Models
{
    public class ApplicationUser : IdentityUser
    {
        //Foreign Key
        public int? CourseId { get; set; }


        //Navigation Property
        public Course Course { get; set; }


        //-----------------------

        
        [Display(Name = "Name"), StringLength(20)]
        public string SecondUserName { get; set; }

        //-----------------------------------------
        //Navigation Property
        public ICollection<Document> Documents { get; set; }

    }
}
