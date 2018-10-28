namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.x = 1;
            p.y = 3;
            p.symbol = '*';
            p.Draw();

            Point p1 = new Point();
            p1.x = 2;
            p1.y = 4;
            p1.symbol = '*';
            p1.Draw();
        }
    }
}