using System;

namespace FunStackStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = Factory.Construct('h', 'e', 'l', 'l', 'o');
            var space = Factory.Construct(' ');
            var world = Factory.Construct('w', 'o', 'r', 'l', 'd');
            var user = Factory.Construct('u', 's', 'e', 'r');
            var s = hello + space + world;
            var f = s + space + hello + space + user;
            Console.WriteLine(s);
            Console.WriteLine(f);
            Console.WriteLine(s + s + f);
            Console.WriteLine($"Since f's type is {f.GetType().Name} its length is {f.Length}");
        }
    }
}
