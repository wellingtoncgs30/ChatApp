using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChatApp.Models
{
    public class User : IdentityUser
    {
        [NotMapped]
        [Required]
        public string ConfirmPassword { get; set; }
        public ICollection<ChatUser> Chats { get; set; }
    }
}