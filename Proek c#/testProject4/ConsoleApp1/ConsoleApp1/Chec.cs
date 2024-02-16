using System.Xml.Serialization;

namespace User_L
{
    public class Chec : User_list
    {

        XmlSerializer svusers = new XmlSerializer(typeof(User_list));
        XmlSerializer svqw = new XmlSerializer(typeof(Questions_List));
        Questions_List questions = new Questions_List();
        User_list user_List = new User_list();
        User user = new User();

        //public void record_in_list()
        //}
        //   string pathToFile = "c:../../../../cities.txt";
        //
        //   string[] readEveryLine = new string[20];
        //   readEveryLine = File.ReadAllLines(pathToFile);
        //   
        //   for (int i = 0; i < readEveryLine.Length; i++)
        //   {
        //       user_List.users.Add(new User { Login = readEveryLine[i], Password = readEveryLine[i + 1]});
        //       i++;
        //}
        //
        //public void record_in_file(string name, string pass)
        //}
        //   string pathToFile = "c:../../../../cities.txt";
        //   File.AppendAllText(pathToFile, name);
        //   File.AppendAllText(pathToFile, "\n");
        //   File.AppendAllText(pathToFile, pass);
        //   File.AppendAllText(pathToFile, "\n");
        //
        //}


        public void SaveUser()
        {
            using (Stream fStream = File.Create("../../../../users.txt"))
            {
                svusers.Serialize(fStream, user_List);
            }

        }
        public void SaveQuestion()
        {
            using (Stream fStream = File.Create("../../../../questions.txt"))
            {
                svqw.Serialize(fStream, questions);
            }
        }
        public void LoadUser()
        {
            using (Stream fStream = File.OpenRead("../../../../users.txt"))
            {
                user_List = (User_list)svusers.Deserialize(fStream);
            }

        }
        public void LoadQuestion()
        {
            using (Stream fStream = File.OpenRead("../../../../questions.txt"))
            {
                questions = (Questions_List)svqw.Deserialize(fStream);
            }
        }
        public bool registr()
        {
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
            user_List.users.Add(new User { Login = user.Login, Password = user.Password, Record = user.Record });
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("User successfully added !");
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(1000);

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

            foreach (var combi in user_List.users)
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

                foreach (var user in user_List.users)
                {
                    if (user.Login == Login)
                    {
                        foreach (var user2 in user_List.users)
                        {
                            if (user2.Login == Login)
                            {
                                user2.Password = New;

                            }
                        }
                        return true;
                    }
                }
                return false;
            }
            if (correct() == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("SUCCESSFULLY CHANGED");
                System.Threading.Thread.Sleep(1000);

                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("SOMETHING WENT WRONG");
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        public void Start_Queez()
        {
            Console.WriteLine("\n\t\tWe have two types choose one <'History' 'Geography'>");
            Console.WriteLine("1)History \n2)Geography");
            Console.Write("\n\tchoose : ");

            int sellect = Int32.Parse(Console.ReadLine());

            if (sellect == 1)
            {
                foreach (var quest in questions.questions_History)
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
            else if (sellect == 2)
            {

                foreach (var quest in questions.questions_Geography)
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

            foreach (var item in user_List.users)
            {
                if (item.Login == user.Login)
                {
                    item.Score = user.Score;
                    item.Record.Add(user.Score);
                }

            }
            user.Score = 0;
        }
        public void Past_Quiz()
        {
            foreach (var item in user_List.users)
            {
                if (item.Login == user.Login)
                {
                    for (int i = 1; i < item.Record.Count; i++)
                    {
                        Console.WriteLine($"Username : {user.Login} = {item.Record[i]} ");
                    }
                }
            }
            System.Threading.Thread.Sleep(3000);
        }
        public void compair()
        {
            user_List.users.Sort((x, y) => x.Record.Max().CompareTo(y.Record.Max()));
            foreach (var item in user_List.users)
            {
                Console.WriteLine($"{item.Login} with {item.Record.Max()} point's");
            }
            System.Threading.Thread.Sleep(3000);
        }
        public void admin_add()
        {
            LoadQuestion();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tChoose in which area you want add item ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("<'1)History' '2)Geography'> \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write("\n\t\tchoose : ");
            int choiceQuiz = Int32.Parse(Console.ReadLine());

            var viktorina = questions.questions_History;
            if (choiceQuiz == 1) viktorina = questions.questions_History;
            else if (choiceQuiz == 2) viktorina = questions.questions_Geography;

            Console.Write("\t\t\t Enter a question: ");
            string question = Console.ReadLine();
            Console.Clear();
            Console.Write("\t\t\t Enter a answer 1: ");
            string answer1 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter -> <1)true 2)false> : ");
            Console.ForegroundColor = ConsoleColor.White;
            int boool = Int32.Parse(Console.ReadLine());
            bool correct1 = false;

            if (boool == 1)
            {
                correct1 = true;
            }
            else if (boool == 2)
            {
                correct1 = false;
            }

            Console.Write("\t\t\t Enter a answer 2: ");
            string answer2 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter -> <1)true 2)false> : ");
            Console.ForegroundColor = ConsoleColor.White;
            int boool1 = Int32.Parse(Console.ReadLine());
            bool correct2 = false;
            if (boool1 == 1)
            {
                correct2 = true;
            }
            else if (boool1 == 2)
            {
                correct2 = false;
            }

            Console.Write("\t\t\t Enter a answer 3: ");
            string answer3 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter -> <1)true 2)false> : ");
            Console.ForegroundColor = ConsoleColor.White;
            int boool2 = Int32.Parse(Console.ReadLine()); ;
            bool correct3 = false;
            if (boool2 == 1)
            {
                correct3 = true;
            }
            else if (boool2 == 2)
            {
                correct3 = false;
            }


            Console.Write("\t\t\t Enter a answer 4: ");
            string answer4 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter -> <1)true 2)false> : ");
            Console.ForegroundColor = ConsoleColor.White;
            int boool3 = Int32.Parse(Console.ReadLine()); ;
            bool correct4 = false;
            if (boool3 == 1)
            {
                correct4 = true;
            }
            else if (boool3 == 2)
            {
                correct4 = false;
            }

            viktorina.Add(

               new Question()
               {
                   Text = question,
                   Answers = new List<Answer>()
                   {
                        new Answer() { Text = answer1, IsCorrect=correct1 },
                        new Answer() { Text = answer2, IsCorrect=correct2 },
                        new Answer() { Text = answer3, IsCorrect=correct3 },
                        new Answer() { Text = answer4, IsCorrect=correct4 },

                   }
               });
            Console.Clear();
            SaveQuestion();
            Thread.Sleep(1000);
        }
        public void admin_del()
        {
            LoadQuestion();
            Console.Clear();
            Console.WriteLine();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\t\tChoose in which area you want add item ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("<'1)History' '2)Geography'> \n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write("\n\t\tchoose : ");
            int choice = Int32.Parse(Console.ReadLine());

            var viktorina = questions.questions_History;
            if (choice == 1) viktorina = questions.questions_History;
            else if (choice == 2) viktorina = questions.questions_Geography;
            int i = 0;
            foreach (var item in viktorina)
            {
                Console.WriteLine($"{i + 1}) {item}"); ;
                //Console.WriteLine();
                i++;
            }

            Console.WriteLine("\t\t\t> Choose num for delete: ");
            int number = Int32.Parse(Console.ReadLine());
            try
            {
                viktorina.RemoveAt(number - 1);
                Console.ForegroundColor = ConsoleColor.Green;
                SaveQuestion();
                Console.WriteLine("\t\t\tDeleted succseesful. ");
                Console.ResetColor();
                Thread.Sleep(1000);

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR");
            }
        }

    }
}
