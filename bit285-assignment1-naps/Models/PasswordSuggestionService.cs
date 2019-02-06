using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace bit285_assignment1_naps.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class PasswordSuggestionService
    {

        public string GeneratePassword(User user)
            {
            Random rnd = new Random();
            string[] info = new string[] {user.FirstName,user.LastName,user.Birthyear,user.FavoriteColor,user.Program };
            int i= rnd.Next(0, info.Length-1);

            int j = rnd.Next(0,info.Length-1);
            while(i==j)
                j = rnd.Next(0, info.Length - 1);
            //string str = info[i];
            //str = string.Concat(info[j]);
            //return (str);
            return info[i]+info[j];
            }
           

    }
}
