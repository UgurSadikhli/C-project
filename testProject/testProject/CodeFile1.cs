namespace User_L
{
    class Interfase : User
    {
        public void start()
        {
            Class1 class1 = new Class1();
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
                       op = class1.registr();
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
                    choose = class1.passCh();
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
            string? old;
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
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        Console.Write("\nOld password : ");
                        old = Console.ReadLine();
                        Console.Write("New password : ");
                        New = Console.ReadLine();
                        //Change(old, New);
                        break;
                    case 5:
                        string temp = "███";
                        Console.Clear();
                        for (int k = 0; k < 20; k++)
                        {
                            Console.Clear();
                            Console.WriteLine($"\t\t\t\t\t Exiting {k * 5} % \n\n");
                            Console.Write("\t\t\t" + temp);
                            temp += "██";
                            System.Threading.Thread.Sleep(50);
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