using System;

namespace Prov2
{
    public class DasClassWarrior
    {
        private Random generator = new Random();//Skapar en slump generator.

        int speed = 0;
        int strength = 0;
        int wisdom = 0;

        public DasClassWarrior()
        {
            speed = generator.Next(1,3);

            strength = generator.Next(7,10);

            wisdom = generator.Next(1,10);
        }
    }
}
