namespace DatingApp.API.Dtos
{
    public class UserForLoginDto
    {
        public UserForLoginDto(string username, string password)
        {
            this.Username = username;
            this.Password = password;

        }
        public string Username { get; set; }

        public string Password { get; set; }
    }
}