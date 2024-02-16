using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_L
{
    class User_list
    {
        public List<User> users = new()
        {

            new User()
            {
                Login = "Sanya",
                Password = "1",
                Score = 17
            },
            new User()
            {
                Login = "Maga",
                Password = "1",
                Score = 5
            },
            new User()
            {
                Login = "Ugur",
                Password = "123",
                Score = 12
            }
        };
    }
}
