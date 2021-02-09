using System.CodeDom.Compiler;
using System;

namespace Prov2
{
    public class DasClassSprinter : Stats
    {
        private Random generator = new Random();//Skapar en slump generator.

        int speed = 0;
        int strength = 0;
        int wisdom = 0;

        public DasClassSprinter()
        {
            speed = generator.Next(7,10);

            strength = generator.Next(1,3);

            wisdom = generator.Next(1,10);
        }
    }
}
