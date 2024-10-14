using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    internal class Message
    {
        public Message() { }
        public Guid Id { get; set; }
        public string Text { get; set; } = string.Empty;
        public DateTime SendDate { get; set; }

        public Guid UserId { get; set; }
        public Guid ChatId {  get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Chat Chat { get; set; } = null!;

        public bool IsDeleted { get; set; }
    }
}
