using System;
using System.Collections.Generic;
using System.Text;

namespace Minifigures.Figures
{
    class BreadMan
    {
        public string Name { get; set; }

        public int ShoutCount { get; set; }

        public bool _satisfiedCondition { get; set; }

        public BreadMan(string name)
        {
            Name = name;
        }

        public void Shout()
        {
            int times;
            Console.WriteLine($"How many times should {Name} shout?");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out times))
                {
                    ShoutCount += times;
                    Console.WriteLine($"{Name} has shouted {ShoutCount} shouts");
                    break;
                }
                Console.WriteLine("You have to enter a number!");
            }
            if (ShoutCount >= 25)
            {
                _satisfiedCondition = true;
            }
        }
    }
}
