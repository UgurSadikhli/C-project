using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_L
{
    class Chec :User_list
    {
        Questions_List questions = new Questions_List();
        User_list user_List = new User_list();
        Answer answer = new Answer();
        User user = new User();




        public void text()
        {
            string pathToFile = "C:\\Users\\Ugur\\Desktop\\cities.txt";

            string[] readEveryLine = new string[20];
            readEveryLine = File.ReadAllLines(pathToFile);

            for (int i = 0; i < readEveryLine.Length; i++)
            {
                user_List.users.Add(new User { Login = readEveryLine[i], Password = readEveryLine[i + 1] });
                i++;
            }
        }
        public void righti(string name,string pass)
        {
            string pathToFile = "C:\\Users\\Ugur\\Desktop\\cities.txt";

            File.AppendAllText(pathToFile, name);
            File.AppendAllText(pathToFile,"\n");
            File.AppendAllText(pathToFile, pass);
            File.AppendAllText(pathToFile, "\n");


        }
        public bool registr()
        {
            //user_List.users.Clear();
            text();
            foreach (var co in user_List.users)
            {
                Console.WriteLine($"name -> {co.Login}");
                Console.WriteLine($"password -> {co.Password}");
            }
            Console.Write("login > ");
            user.Login = Console.ReadLine();
            Console.Write("password > ");
            user.Password = Console.ReadLine();

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
            //user_List.users.Add(new User { Login = user.Login, Password = user.Password});
            righti(user.Login, user.Password);
            return false;
        }
        public int passCh()
        {
            text();
            foreach (var co in user_List.users)
            {
                Console.WriteLine($"name -> {co.Login}");
                Console.WriteLine($"password -> {co.Password}");
            }
            Console.Write("\nlogin > ");
            string? name = Console.ReadLine();

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
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("operation done !!");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    string temp = "██";
                    Console.Clear();
                    for (int k = 0; k < 21; k++)
                    {
                        Console.Clear();
                        Console.WriteLine($"\t\t\t\t\t Loading {k * 5} % \n\n");
                        Console.Write("\t\t\t" + temp);
                        temp += "██";
                        System.Threading.Thread.Sleep(50);
                    }
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
        }
        public void Past_Quiz()
        {
            foreach (var quest in questions.questions)
            {
            }


        }
    }
}
