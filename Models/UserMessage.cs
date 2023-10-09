namespace Auction.Models
{
    public class UserMessage
    {
        public string Username { get; set; } = "";
        public string Message { get; set; } = "";
        public bool CurrentUser { get; set; }
        public DateTime DateSend { get; set; }
    }

}

