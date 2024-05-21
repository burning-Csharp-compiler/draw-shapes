namespace Tannenbaum
{
    internal class Tannenbaum
    {
        static void Main(string[] args)
        {
            const int cb = 10; 
            const int ch = 10;
            int b = cb;
            int h = ch;
            char c = 'X';
            char e = ' ';

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
                for (int x = 1; x < y + 1; ++x)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            for (int y = 7; y < b; ++y)
            {
                for (int x = 2; x < b; ++x)
                {
                    Console.Write(e);
                }
                for (int x = 7; x < b; ++x)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}
