using System;
using System.Runtime.InteropServices;

namespace src
{
    class Program
    {
        [DllImport(@"../lib/libpantilt.so")]
        public static extern void PCA9685_init(byte address);

        [DllImport(@"../lib/libpantilt.so")]
        public static extern void PCA9685_setPWMFreq(float freq);

        [DllImport(@"../lib/libpantilt.so")]
        public static extern int ServoDegreeIncrease(byte channel, byte step);

        [DllImport(@"../lib/libpantilt.so")]
        public static extern int ServoDegreeDecrease(byte channel, byte step);

        static void Main(string[] args)
        {
            PCA9685_init(0x80);
            PCA9685_setPWMFreq(60);
            ServoDegreeIncrease(0, 10);
            
            while (true) 
            {
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.UpArrow:
                        ServoDegreeIncrease(0, 1);
                        break;
                    case ConsoleKey.DownArrow:
                        ServoDegreeDecrease(0, 1);
                        break;
                    case ConsoleKey.LeftArrow:
                        ServoDegreeDecrease(1, 1);
                        break;
                    case ConsoleKey.RightArrow:
                        ServoDegreeIncrease(1, 1);
                        break;
                }
            }
        }
    }
}
