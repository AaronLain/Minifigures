using System;

namespace Minifigures.Figures
{
    class BananaMan
    {
        public string Name { get; set; }

        public int JumpCount { get; set; }

        public bool _satisfiedCondition { get; private set; }

        public BananaMan (string name)
        {
            Name = name;
        }
        
        public void Jump()
        {
            int times;
            Console.WriteLine($"How many times should {Name} jump?");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out times))
                {
                    JumpCount += times;
                    Console.WriteLine($"{Name} has jumped {JumpCount} jumps");
                    break;
                }
                Console.WriteLine("You have to enter a number!");
            }
            if (JumpCount >= 25)
            {
                _satisfiedCondition = true;
            }
        }
    }
}
