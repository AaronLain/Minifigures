using System;

namespace Minifigures.Figures
{
    class BananaBreadMan
    {
        public string Name { get; set; }

        public BananaBreadMan(string name)
        {
            Name = name;
        }

        public void Hello()
        {
            Console.WriteLine($"You sucessfully created The Banana Bread Man! {Name} says Hello!");
        }
    }
}
