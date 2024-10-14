﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    internal class User
    {
        public Guid Id { get; set; }

        public byte[]? Image { get; set; } = [];
        public string Color { get; set; } = string.Empty;
        public string Nickname { get; set; } = string.Empty;
        public string Tag { get; set; } = string.Empty;
        public string CustomStatus { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        public DateTime LastActive { get; set;}
        public Statuses Status { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<Chat> Chats { get; set; } = null!;

        [NotMapped]
        public string Username => $"{Nickname}#{Tag}";
        public string CreationDateFormated => CreationDate.ToString("f");
        public string LastActivityFormated => CreationDate.ToString("f");
        public string ImagePath => string.Empty;
        public string Password => string.Empty;
    }
}
