namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 3, '*');
            p.Draw();

            Point p1 = new Point(2, 4, '*');         
            p1.Draw();
        }
    }
}