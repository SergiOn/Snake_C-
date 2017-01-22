﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 80, 25 );

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(1, 23, 0, '+');
            VerticalLine rightLine = new VerticalLine(1, 23, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point( 4, 5, '*' );
            Snake snake = new Snake( p, 4, Direction.RIGHT );
            snake.Draw();

            while (true)
            {
                if( Console.KeyAvailable )
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey( key.Key );
                }
                Thread.Sleep(300);
                snake.Move();
            }
        }
    }
}
