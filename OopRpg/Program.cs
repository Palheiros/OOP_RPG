using OopRpg.Entities;
using static System.Console;

namespace OopRpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 42, "Knight", 56, 25);
            Knight cecil = new Knight("Cecil", 99, "White Knight", 120, 45);
            Wizard jennica = new Wizard("Jennica", 32, "Black Wizard", 40, 120);
            Ninja wedge = new Ninja("Wedge", 42, "Shinobi", 80, 40);

            WriteLine(arus);
            WriteLine(cecil);
            WriteLine(jennica);
            WriteLine(wedge);
            WriteLine(arus.Attack());
            WriteLine(jennica.Attack());
            WriteLine(wedge.Attack(7));
            WriteLine(cecil.Attack(8));
            WriteLine("------ Second Round! ------\n");
            WriteLine(arus.Attack(3));
            WriteLine(jennica.Attack(10));
            WriteLine(cecil.Attack(4));
            WriteLine(wedge.Attack());
        }        
    }
}
