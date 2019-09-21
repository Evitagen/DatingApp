namespace DatingApp.API.Models
{
    public class Like
    {
        public int LikerId { get; set; }
        public int LikeeId { get; set; }
        public virtual user Liker { get; set; }
        public virtual user Likee { get; set; }
    }
}