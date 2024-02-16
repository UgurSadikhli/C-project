namespace User_L
{
    public class Program
    {
        static void Main(string[] args)
        {
            Chec chec = new Chec();
            int check = 0;
            bool flaq = true;
            try
            {
                while (flaq)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\t\t\t█████████████████████████████");
                    Console.Write("\t\t\t█");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("    1) Add question  \t    ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("█\n");
                    Console.Write("\t\t\t█");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("    2) Remove question     ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("█");
                    Console.Write("\n\t\t\t█");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("    3) Exit                ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("█\n");
                    Console.WriteLine("\t\t\t█████████████████████████████");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.Write("\n\t\t\tchoise : ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    int choice = Int32.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            chec.admin_add();
                            break;
                        case 2:
                            chec.admin_del();
                            break;
                        case 3:
                            flaq = false;
                            break;
                        default:
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine($"\n\t\t\tError");
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
    }
}

