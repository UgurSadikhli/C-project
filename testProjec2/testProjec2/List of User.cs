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
                Login = "Ugur",
                Password = "123",
                Score = 12
            }


        };
    }
}
