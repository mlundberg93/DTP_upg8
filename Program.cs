using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;

namespace D8_porting
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string title;
            string text;
            Console.WriteLine("Välkommen till sceneriet!");
            title = Scenery.HelpTitle();
            text = Scenery.HelpText();


            Console.WriteLine("--------------");
            Console.WriteLine(title);
            Console.WriteLine("--------------");
            Console.WriteLine(text);
            Console.WriteLine("--------------");
            Console.WriteLine("Skriv 'h' för hjälp, 'x' för att sluta!");

            do
            {
                Console.Write("> ");
                string command = Console.ReadLine();
                if(command == "x")
                {
                    Console.WriteLine("Hej då!");
                    break;
                }
                else if(command == "h")
                {
                    title = Scenery.HelpTitle();
                    text = Scenery.HelpText();
                }
                else
                {
                    Scenery.DoCommand(command);
                    title = Scenery.CurrentTitle(command);
                    text = Scenery.CurrentText(command);
                }
                Console.WriteLine("--------------");
                Console.WriteLine(title);
                Console.WriteLine("--------------");
                Console.WriteLine(text);
                Console.WriteLine("--------------");
                Console.WriteLine("Skriv 'h' för hjälp, 'x' för att sluta!");
            } while (true);
        }
    }
}