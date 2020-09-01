using System;

namespace ChatApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
        public int ChatId { get; set; }
        public Chat Chat { get; set; }
        public Message()
        {

        }
        public Message(int id, string name, string text, DateTime timestamp, int chatId, Chat chat)
        {
            Id = id;
            Name = name;
            Text = text;
            Timestamp = timestamp;
            ChatId = chatId;
            Chat = chat;
        }
    }
}