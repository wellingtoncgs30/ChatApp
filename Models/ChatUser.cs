using ChatApp.Models.Enum;

namespace ChatApp.Models
{
    public class ChatUser
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public int ChatId { get; set; }
        public Chat Chat { get; set; }
        public UserRole Role { get; set; }
        public ChatUser()
        {

        }
        public ChatUser(string userId, User user, int chatId, Chat chat, UserRole role)
        {
            UserId = userId;
            User = user;
            ChatId = chatId;
            Chat = chat;
            Role = role;
        }
    }
}