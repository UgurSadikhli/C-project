using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_L
{
    class Class1
    {
        User user = new User();
        public void text()
        {
            string[] readEveryLine = new string[7];
            readEveryLine = File.ReadAllLines(pathToFile);
            Console.WriteLine(readEveryLine[0]);
            Console.WriteLine(readEveryLine[1]);
        
            for (int i = 0; i < readEveryLine.Length; i++)
            {
                user.users.Add(new User { Login = readEveryLine[i], Password = readEveryLine[i+1] });
        
            }
        }
        string pathToFile = "C:\\Users\\Ugur\\Desktop\\cities.txt";
        public bool registr()
        {
            Console.Write("login > ");
            user.Login = Console.ReadLine();
            Console.Write("password > ");
            user.Password = Console.ReadLine();

            //File.AppendAllText(pathToFile, Environment.NewLine); // Добавим новую строку в наш файл
            File.AppendAllText(pathToFile, user.Login);
            File.AppendAllText(pathToFile, "\n");
            File.AppendAllText(pathToFile, user.Password);
            // text();

            return false;
        }
        public int passCh()
        {

            Console.Write("login > ");
            string? name = Console.ReadLine();

            if (name == "000")
            {
                string temp = "██";
                Console.Clear();
                for (int k = 0; k < 15; k++)
                {
                    Console.Clear();
                    Console.WriteLine($"\t\t\t\t\t LOGING OUT {k * 2} % \n\n");
                    Console.Write("\t\t\t" + temp);
                    temp += "██";
                    System.Threading.Thread.Sleep(50);
                }

                return 0;
            }
            Console.Write("password > ");
            string? password2 = Console.ReadLine();

            foreach (var combi in user.users)
            {
                if (combi.Login == name && combi.Password == password2)
                {
                    user.Login = name;
                    user.Password = password2;
                    //Score = user_List.users[index].Score;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("operation done !!");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    return 1;
                }
            }

            foreach (var combi in user.users)
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
    }
}
