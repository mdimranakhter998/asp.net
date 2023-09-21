﻿using EcommerceUI.Admin.Validators.Gender;
using System.ComponentModel.DataAnnotations;


namespace EcommerceUI.Admin.Models.User
{

   
    public class GenderModel
    {
        [Display(Name = "Id")]
        public int GenderId { get; set; }
        [Display(Name = "Gerder")]
        public string GenderType { get; set; }
    }
}
