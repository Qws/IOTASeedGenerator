using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOTASeedGenerator
{
    class SeedCharacters
    {
        private string stringOfPossibilities;
        private char[] possibilities;
        Random random;

        public SeedCharacters()
        {
            random = new Random();
            stringOfPossibilities = "9ABCDEFGHIJKLMONPQRSTUVWYXZ";
            possibilities = new char[27];
            possibilities = stringOfPossibilities.ToCharArray();
        }

        public char GetRandomKey()
        {
            char key;
            key = possibilities[(random.Next(0, 27))];

            /*
            possibilities[0] = "0";
            possibilities[1] = "1";
            possibilities[2] = "2";
            possibilities[3] = "3";
            possibilities[4] = "4";
            possibilities[5] = "5";
            possibilities[6] = "6";
            possibilities[7] = "7";
            possibilities[8] = "8";
            possibilities[9] = "9";
            possibilities[10] = "A";
            possibilities[11] = "B";
            possibilities[12] = "C";
            possibilities[13] = */


            return key;
        }
    }
}
