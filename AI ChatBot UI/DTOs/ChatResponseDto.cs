namespace AI_ChatBot_UI.DTOs
{
    public class ChatResponseDto
    {
        public int Id { get; set; }  // Add this
        public int UserId { get; set; }  // User message ID - ADD THIS
        public string Message { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }
        public bool IsApproved { get; set; }  // Add this if needed
    }
}
