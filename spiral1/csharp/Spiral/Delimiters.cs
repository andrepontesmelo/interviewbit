using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    public class Demiliters
    {
        private int left;

        public int Left
        {
            get { return left; }
            set { left = value; }
        }
        private int right;

        public int Right
        {
            get { return right; }
            set { right = value; }
        }
        private int bottom;

        public int Bottom
        {
            get { return bottom; }
            set { bottom = value; }
        }
        private int top;

        public int Top
        {
            get { return top; }
            set { top = value; }
        }

        public Demiliters(int[,] matrix)
        {
            top = 0;
            left = 0;
            
            bottom = matrix.GetLength(0) - 1;
            right = matrix.GetLength(1) - 1;
        }

        public bool Finished
        {
            get
            {
                return !((top <= bottom) && (left <= right));
            }
        }
    }
}
