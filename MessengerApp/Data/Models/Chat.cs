using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    internal class Chat
    {
        public Chat () { }

        public Chat(string title, bool isGroup) 
        {
            Id = Guid.NewGuid();
            Title = title;
            IsGroup = isGroup;
            IsDeleted = false;
        }

        public Guid Id {  get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime CreationDate { get; set; }
        public bool IsGroup { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<User> Users { get; set; } = null!;
        public virtual ICollection<Message> Messages { get; set; } = null!;
    }
}
