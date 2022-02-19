using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrainTicket.Models
{
    public class UserInformation
    {
        [Key]
        public int UserID { get; set; }
        public string UserFullName { get; set; }
        public string UserPhoneNumber { get; set; }

        [EmailAddress]
        public string UserEmail { get; set; }

        [Compare("UserCPassword", ErrorMessage = "Password Doesn't Match")]
        public string UserPassword { get; set; }

        public string ProfilePicture { get; set; }
        public bool IsActive { get; set; }

        [NotMapped]
        public string UserCPassword { get; set; }
        [NotMapped]
        public IFormFile ProfileImage { get; set; }
        public string UserType { get; set; }


        
    }


}
