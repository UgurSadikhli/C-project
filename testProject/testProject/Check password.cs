using System.Threading;

namespace User_L
{
    public class User
    {
        public string? Login { get; set; }
        public string? Password { get; set; }
        //public int Score { get; set; }

        public List<User> users = new()
        {
            new User()
            {
                Login = "Sanya",
                Password = "1",
                //Score = 17
            }
        };

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        
        public User()
        {
        }


        
        //public void Change(string Old, string New)
        //{
        //    bool correct()
        //    {
        //        foreach (KeyValuePair<string, string> combi3 in capitalOf)
        //        {
        //            if(combi3.Key == New)
        //            {
        //                return false;
        //            }
        //        }
        //        foreach (KeyValuePair<string, string> combi in capitalOf)
        //        {
        //            if (combi.Key == Old)
        //            {
        //                string? login = combi.Value;
        //                var keyToRemove = Old;
        //                capitalOf.Remove(keyToRemove);
        //                capitalOf.Add(New, login);
        //                return true;
        //            }
        //
        //        }
        //        return false;
        //    }
        //    if (correct() == true)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine("SUCCESSFULLY CHANGED");
        //        Console.ForegroundColor = ConsoleColor.White;   
        //    }
        //    else
        //    {
        //        Console.Beep();
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("SOMETHING WENT WRONG");
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //    foreach (KeyValuePair<string, string> combi2 in capitalOf)
        //    {
        //        Console.WriteLine($"{combi2.Key} - {combi2.Value}");
        //        System.Threading.Thread.Sleep(700);
        //    }
        //}
    }
}