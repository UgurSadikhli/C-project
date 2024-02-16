namespace User_L
{
    public class Interfase : User
    {

        Chec chec = new Chec();
        public void start()
        {


            bool flaq2 = true;
            while (flaq2)
            {
                int ch = 0;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t\t\t█████████████████████████████");
                Console.Write("\t\t\t█");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t1) register\t    ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("█\n");
                Console.Write("\t\t\t█");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\t2) login\t    ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("█\n");
                Console.WriteLine("\t\t\t█████████████████████████████");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("\n\t\t\tchoise : ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    ch = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" WRONG !!");
                    Console.ForegroundColor = ConsoleColor.White;

                }

                if (ch == 1)
                {
                    bool op = true;
                    bool flaq = true;
                    while (flaq)
                    {
                        op = chec.registr();
                        if (op == true)
                        {
                            flaq = true;
                        }
                        else
                        {
                            flaq = false;
                        }
                    }
                }
                else if (ch == 2)
                {
                    bool flaq = true;
                    while (flaq)
                    {
                        int choose = 0;
                        choose = chec.passCh();
                        if (choose == 1)
                        {
                            flaq = false;
                            flaq2 = false;
                        }
                        else if (choose == 0)
                        {
                            flaq = false;
                        }
                        else if (choose == 2)
                        {
                            flaq = true;
                        }
                    }
                }
            }
        }

        public void main_on()
        {

            int choose = 0;
            string? log;
            string? New;
            chec.LoadQuestion();
            chec.LoadUser();

            bool flaq = true;
            start();
            while (flaq)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t\t\t╔════════════════════════════════════════════╗");
                Console.Write("\t\t        ║");
                Console.Write("\t\t\t\t\t     ║\n");
                Console.Write("\t\t        ║");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("   1) start a new quiz");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\t\t\t     ║\n");
                Console.Write("\t\t        ║ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  2) see the results of your past quizzes ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" ║\n");
                Console.Write("\t\t        ║ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  3) see the Top for a specific quiz ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("      ║\n");
                Console.Write("\t\t        ║ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  4) change the password");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" \t\t     ║\n");
                Console.Write("\t\t        ║ ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  5) exit ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\t\t\t\t     ║ ");
                Console.Write("\n\t\t        ║");
                Console.Write("\t\t\t\t\t     ║");
                Console.WriteLine("\n\t\t\t╚════════════════════════════════════════════╝");
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write("\n\t\t\tchoise : ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    choose = Convert.ToInt32(Console.ReadLine());
                    Questions_List questions = new Questions_List();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR !!");
                }

                switch (choose)
                {
                    case 1:
                        string temp = "██";
                        for (int k = 0; k < 21; k++)
                        {
                            Console.Clear();
                            Console.WriteLine($"\t\t\t\t\t Starting new quiz {k * 5} % \n\n");
                            Console.Write("\t\t\t" + temp);
                            temp += "██";
                            System.Threading.Thread.Sleep(50);
                        }
                        System.Threading.Thread.Sleep(100);
                        Console.Clear();
                        chec.Start_Queez();
                        break;
                    case 2:
                        chec.Past_Quiz();
                        break;
                    case 3:
                        chec.compair();
                        break;
                    case 4:
                        Console.Write("\nUsername : ");
                        log = Console.ReadLine();
                        Console.Write("New password : ");
                        New = Console.ReadLine();
                        chec.Change(log, New);
                        break;
                    case 5:
                        string temp2 = "██";
                        Console.Clear();
                        for (int k = 0; k < 21; k++)
                        {
                            Console.Clear();
                            Console.WriteLine($"\t\t\t\t\tSving data {k * 5} % \n\n");
                            Console.Write("\t\t\t" + temp2);
                            temp2 += "██";
                            System.Threading.Thread.Sleep(110);
                        }
                        chec.SaveQuestion();
                        chec.SaveUser();

                        flaq = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}