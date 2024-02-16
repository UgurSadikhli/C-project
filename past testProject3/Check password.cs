using System.Threading;

namespace User_L
{
    public class User
    {
        public string? Login { get; set; }
        public string? Password { get; set; }
        public int Score { get; set; } = 0;

        public List<int> Record = new()
        {

        };
        public User(string login, string password,int score)
        {
            Login = login;
            Password = password;
            Score = score;
        }

        public User()
        {
        }

    }
}