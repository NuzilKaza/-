using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
            Console.WriteLine("Point creating");
        }

        public Point(Point P)
        {
            x = P.x;
            y = P.y;
            sym = P.sym;
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) x += offset;
            else if (direction == Direction.LEFT) x -= offset;
            else if (direction == Direction.DOWN) y -= offset;
            else y += offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
