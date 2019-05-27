using System;

namespace WindowsFormsApp4
{
    class SquarePrism : Square
    {
        private int height;
        private int side;
        public int Height { get => height; set => height = value == 0 ? 1 : value; }
        public new int Side { get => side; set => side = value == 0 ? 1 : value; }


        public SquarePrism()
        {
        }


        public SquarePrism(int height, int side)
        {
            Height = height;
            Side = side;
        }


        public double DiagonalOfSide() => Math.Sqrt((Math.Pow((double)Side, 2) + Math.Pow((double)Height, 2)));


        public int SizePrism(int area) => height * area;


        public double SizePrism(double height, int area) => height * area;


        public double DiagonalPrism() => Math.Sqrt(Math.Pow(Side, 2) + Math.Pow(DiagonalOfSide(), 2));


        public override string ToString()
        {
            return "\nHeight: " + Height + "\nBottom Side: " + Side + "\nSize: " + SizePrism(Height, Area(Side)) + "\nDiagonal of Prism: " + DiagonalPrism();
        }
    }
}
