using System;

class Program
{
    public static void Main(string[] args)
    {
        bool stch = true;
        while (stch)
        {
            Console.Write("rentrer un nombre flottant: ");
            string entry = Console.ReadLine();
            int flo = default;
            bool sucess = false;
            while (!(sucess))
            {
                sucess = int.TryParse(entry, out flo);
                if (!(sucess))
                {
                    Console.Write("Error: celui ci n'est pas un flottant. rappel: les flottants portent des commas et non des points. ");
                    entry = Console.ReadLine();
                    while (!(flo >= 0 && flo <= 100.999999))
                    {
                        Console.Write("Error: le float n'est pas compris dans le range. essayez à nouveau: ");
                        entry = Console.ReadLine();
                        sucess = int.TryParse(entry, out flo);
                    }
                }
            }

            Console.Write("vous voulez continuer? ");
            string question = Console.ReadLine();
            if (question == "no" || question == "No")
            {
                stch = false;
            }

        }
    }
}