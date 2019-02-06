﻿
using System;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bit285_assignment1_naps.Models
{
    public class User
    {
        ///[Required(ErrorMessage = "*Please enter your first name")]
        public string FirstName { get; set; }

        //[Required(ErrorMessage = "*Please enter your last name")]
        public string LastName { get; set; }

        //[Required(ErrorMessage = "*Please enter your email address")]
        public string EmailAddress { get; set; }

       //[Required(ErrorMessage = "*Please choose your password")]
        public string Password { get; set; }

        //[Required(ErrorMessage = "*Please choose your program")]
        public string Program { get; set; }

        //[Required(ErrorMessage = "*Please enter your birth year")]
        public int Birthyear { get; set; }

        //[Required(ErrorMessage = "*Please enter your favorite color")]
        public string FavoriteColor { get; set; }



    
}

}
