namespace drawRectangle
{
    internal class Rect
    {
        static void Main(string[] args)
        {
            const int ch = 4;
            const int cb = 16;
            int b = cb; //breite
            int h = ch; //höhe
            char c = '#';

            for (int y = ch; y != 0; y--)
            {
                for (int x = cb; x != 0; x--)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            for (int y = h; y != 0; --y)
            {
                for (int x = b; x != 0; --x)
                {
                    Console.Write(c);
                }
                b = cb;
                Console.WriteLine();
            }

            Console.WriteLine();

            while (h > 0)
            {
                while (b > 0)
                {
                    Console.Write(c);
                    --b;
                }
                Console.WriteLine();
                b = cb;
                --h;
            }
        }
    }
}
