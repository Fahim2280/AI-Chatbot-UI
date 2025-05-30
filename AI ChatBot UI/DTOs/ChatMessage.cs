namespace AI_ChatBot_UI.DTOs
{
    public class ChatMessage
    {
        public int Id { get; set; }
        public string SessionId { get; set; } = string.Empty;
        public string Sender { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public bool IsApproved { get; set; }
        public bool IsDeleted { get; set; }

        public bool IsEditing { get; set; } = false;
    }
}
