using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int time= DateTime.Now.Hour;

            if (time<=11)
            {
                System.Console.WriteLine( "Sabah saatleri");
            }
            else if(time<=17)
            {
                System.Console.WriteLine("Öğle saatleri");
            }
            else if (time<=21)
            {
                System.Console.WriteLine("Akşam saatleri");
            }
            else
            System.Console.WriteLine("Gece saatleri");
        }
    }
}
