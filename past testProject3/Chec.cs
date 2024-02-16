using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace User_L
{
    class Chec : User_list
    {
        Questions_List questions = new Questions_List();
        User_list user_List = new User_list();
        User user = new User();
        public bool registr()
        {
            foreach (var co in user_List.users)
            {
                Console.WriteLine(co.Login);
                Console.WriteLine(co.Password);
            }
            Console.Write("login > ");
            user.Login = Console.ReadLine();
            Console.Write("password > ");
            user.Password = Console.ReadLine();
            user.Score = 0;
            foreach (var combi2 in user_List.users)
            {
                if (combi2.Login == user.Login)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                    Console.WriteLine("THIS USER IS ALREADY ACCESSORIES");
                    Console.ForegroundColor = ConsoleColor.White;
                    return true;
                }
            }
            user_List.users.Add(new User { Login = user.Login, Password = user.Password}); 
            return false;
        }

        public int passCh()
        {
            Console.Write("login > ");
            string? name = Console.ReadLine();

            int index = user_List.users.FindIndex(x => x.Login == name);
            if (name == "000")
            {
                string temp = "██";
                Console.Clear();
                for (int k = 0; k < 10; k++)
                {
                    Console.Clear();
                    Console.WriteLine($"\t\t\t\t\t LOGING OUT {k * 11} % \n\n");
                    Console.Write("\t\t\t" + temp);
                    temp += "██";
                    System.Threading.Thread.Sleep(70);
                }

                return 0;
            }

            Console.Write("password > ");
            string? password2 = Console.ReadLine();
            foreach (var combi in user_List.users)
            {
                if (combi.Login == name && combi.Password == password2)
                {
                    user.Login = name;
                    user.Password = password2;
                    user.Score = user_List.users[index].Score;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("operation done !!");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    //string temp = "██";
                    //Console.Clear();
                    //for (int k = 0; k < 21; k++)
                    //{
                    //    Console.Clear();
                    //    Console.WriteLine($"\t\t\t\t\t Loading {k * 5} % \n\n");
                    //    Console.Write("\t\t\t" + temp);
                    //    temp += "██";
                    //    System.Threading.Thread.Sleep(50);
                    //}
                    user.Record.Add(user.Score);
                    return 1;
                }
            }

            foreach(var combi in user_List.users)
            {
                if (combi.Login != name || combi.Password != password2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nnot correct !!");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Enter <000> to logout ...\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write("1) register\n"
                        + "2) login\n"
                        + "\tchoose : 2\n\n");
                    return 2;
                }
            }
            return 0;
        }

        public void Change(string Login, string New)
        {
            bool correct()
            {
                foreach (var combi3 in user_List.users)
                {
                    if (combi3.Password == New)
                    {
                        return false;
                    }
                }
                foreach (var combi in user_List.users)
                {
                    if (combi.Login == Login)
                    {
                        combi.Password = New;   
                        return true;
                    }

                }
                return false;
            }
            if (correct() == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESSFULLY CHANGED");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SOMETHING WENT WRONG");
                Console.ForegroundColor = ConsoleColor.White;
            }
            foreach (var combi2 in user_List.users)
            {
                Console.WriteLine($"{combi2.Password} - {combi2.Login}");
                System.Threading.Thread.Sleep(700);
            }

        }

        public void Start_Queez()
        {
            
            foreach (var quest in questions.questions)
            {
                Console.Clear();
                Console.WriteLine($"your score is :<{user.Score}>");
                Console.WriteLine($"\n\tquestion : {quest}");
                Console.Write("\tanswer : ");
                string otvet = Console.ReadLine();
                if (otvet == "A" && quest.Answers[0].IsCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tCorrect");
                    Console.ForegroundColor = ConsoleColor.White;

                    user.Score++;
                }
                else if (otvet == "B" && quest.Answers[1].IsCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tCorrect");
                    Console.ForegroundColor = ConsoleColor.White;

                    user.Score++;
                }
                else if (otvet == "C" && quest.Answers[2].IsCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tCorrect");
                    Console.ForegroundColor = ConsoleColor.White;

                    user.Score++;
                }
                else if (otvet == "D" && quest.Answers[3].IsCorrect)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\tCorrect");
                    Console.ForegroundColor = ConsoleColor.White;

                    user.Score++;
                }
                else
                {   
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tWrong");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                System.Threading.Thread.Sleep(1000);
            }
            int s = user.Score;
            user.Record.Add(s);
        }

        public void Past_Quiz()
        {
            if(user.Score != 0)
            {
                foreach (var combi in user.Record)
                {
                    Console.WriteLine($"Username : {user.Login} = {combi} ");
                }       
            }
            else
            {
                Console.Write($"Username : {user.Login} = ");
                Console.ForegroundColor= ConsoleColor.Red;
                Console.Write("pass the quiz");
                Console.ForegroundColor = ConsoleColor.White;
            }
            System.Threading.Thread.Sleep(3000);
        }
        public void compair()
        {
            int index = user_List.users.FindIndex(x => x.Login == user.Login);
            int index2 = user.Record.FindIndex(x => x == user.Score);

            user_List.users[index].Score = user.Record[index2];
           user_List.users.Sort((Score, Score1) => Score.Score.CompareTo(Score1.Score));
           foreach (var s in user_List.users)
           {
               Console.WriteLine($"{s.Login} with {s.Score} point's");
           }
            System.Threading.Thread.Sleep(3000);
        }
    }
}
