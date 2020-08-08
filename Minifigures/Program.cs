using Minifigures.Figures;
using System;

namespace Minifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            var vera = new BananaMan("Vera");
            var chuck = new BreadMan("Chuck");

            do
            {
                vera.Jump();
            } while (vera.JumpCount < 25);

            do
            {
                chuck.Shout();
            } while (chuck.ShoutCount < 25);
            

            if (vera._satisfiedCondition == true && chuck._satisfiedCondition == true)
            {
                var dave = new BananaBreadMan("Dave");
                dave.Hello();
            }
        }
    }
}
