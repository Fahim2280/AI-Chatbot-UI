namespace AI_ChatBot_UI.DTOs
{
    public class ChatMessage
    {
        public string Sender { get; set; } = "User";
        public string Message { get; set; } = "";
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
