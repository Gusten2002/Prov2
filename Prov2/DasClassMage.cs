using System;

namespace Prov2
{
    public class DasClassMage
    {
        private Random generator = new Random();//Skapar en slump generator.

        int speed = 0;
        int strength = 0;
        int wisdom = 0;

        public DasClassMage()
        {
            speed = generator.Next(1,10);

            strength = generator.Next(1,3);

            wisdom = generator.Next(7,10);
        }
    }
}
