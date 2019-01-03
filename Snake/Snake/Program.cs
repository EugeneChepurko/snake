using Snake.Stages;
using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(150, 35);
            Start start = new Start();
            start.StartStage_0();
        }
    }
}