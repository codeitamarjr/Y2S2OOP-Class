using System;
namespace Y2S2OOP_Class
{
    public class Square
    {
        private int side;
        private int area;

        public Square(int side)
        {
            this.side = side;
            calcArea();
        }
        private void calcArea()
        {
            area = side * side;
        }
        public int Side
        {
            get
            {
                return side;
            }
        }
        public int Area
        {
            get
            {
                return area;
            }
        }

    }
}
