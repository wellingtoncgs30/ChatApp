using System.Collections.Generic;
using ChatApp.Models.Enum;

namespace ChatApp.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Message> Messages { get; set; } = new List<Message>();
        public ICollection<ChatUser> Users { get; set; } = new List<ChatUser>();
        public ChatType Type { get; set; }
        public Chat()
        {

        }
        public Chat(int id, string name, ChatType type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}