using System;

namespace CatsAndMouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var catAPos = int.Parse(Console.ReadLine());
            var catBPos = int.Parse(Console.ReadLine());
            var mousePos = int.Parse(Console.ReadLine());

            var catADistance = Math.Abs(mousePos - catAPos);
            var catBDistance = Math.Abs(mousePos - catBPos);

            if (catADistance < catBDistance)
            {
                Console.WriteLine("Cat A");
            }
            else if (catBDistance < catADistance)
            {
                Console.WriteLine("Cat B");
            }
            else
            {
                Console.WriteLine("Mouse C");
            }
        }
    }
}
