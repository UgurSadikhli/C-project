namespace User_L
{
    class Interfase : User
    {

        Chec chec = new Chec();
        public void start()
        {
            bool flaq2 = true;
            while (flaq2)
            {
                int ch = 0;
                Console.Clear();
                Console.Write("1) register\n"
                    +"2) login\n"
                    + "\tchoose : ");
                ch = Convert.ToInt32(Console.ReadLine());
          
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
                        else if(choose == 0)
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

            bool flaq = true;
            start();
            while (flaq)
            {
                Console.Clear();
                Console.WriteLine("1) start a new quiz");
                Console.WriteLine("2) see the results of your past quizzes");
                Console.WriteLine("3) see the Top for a specific quiz;");
                Console.WriteLine("4) change the password");
                Console.WriteLine("5) exit");
                Console.Write("\nchoose : ");
                choose = Convert.ToInt32(Console.ReadLine());
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
                        flaq = false;
                        break;
                    default:        
                        break;
                }
            }
        }
    }
}