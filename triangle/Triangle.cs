
namespace triangle
{
    internal class Triangle
    {        
        static void Main(string[] args)
        {
            const int cb = 10;
            const int ch = 10;
            int b = cb;
            int h = ch;
            char c = 'M';
            char e = ' ';

            drawLO(c, h); 
            drawLU(c, h);
            drawRO(c, e, h);
            drawRU(c, e, h, b);          
        }

        private static void drawRU(char c, char e, int h, int b)
        {
            for (int y = 0; y < h; ++y)
            {
                for (int x = 1; x < y + 1; ++x)
                {
                    Console.Write(e);
                }
                for (int x = 0; x < h - y; ++x)
                {
                    Console.Write(c);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void drawLO(char c, int h)
        {
            for (int y = 0; y < h; ++y)
            {
                for (int x = 0; x < h - y; ++x)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void drawLU(char c, int h)
        {
            for (int y = 0; y < h; ++y)
            {
                for (int x = 0; x < y + 1; ++x)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void drawRO(char c, char e, int h)
        {
            for (int y = 0; y < h; ++y)
            {
                for (int x = 1; x < h - y; ++x)
                {
                    Console.Write(e);
                }
                for (int x = 0; x < y + 1; ++x)
                {
                    Console.Write(c);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
