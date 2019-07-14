using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTASeedGenerator
{
    class Generator
    {
        private Seed seed;
        private SeedCharacters seedCharacters;

        public Generator()
        {
            seed = new Seed();
            seedCharacters = new SeedCharacters();
        }

        public Seed CreateSeed()
        {
            char[] seedConstruct = new char[81];
            int counter = 0;
            while (counter <= (seedConstruct.Length - 1))
            {
                seedConstruct[counter] = seedCharacters.GetRandomKey();
                counter++;
            }

            seed.Value = new String(seedConstruct);
            return seed;
        }

    }
}
