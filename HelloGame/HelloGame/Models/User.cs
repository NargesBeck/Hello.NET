namespace HelloGame.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime JoinDate { get; set; }
        public int XP { get; set; }
        public ICollection<Quest> Quests { get; set; }
    }
}