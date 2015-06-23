using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    /// <summary>
    /// Implementation of this problem http://www.interviewbit.com/courses/programming/topics/arrays/problems/spiral1/
    /// </summary>
    public class Spiral
    {
        private int[,] matriz;

        public Spiral()
        {
        }

        public Spiral(int[,] matriz)
        {
            this.matriz = matriz;
        }

        public int[] GetSpiral()
        {
            List<int> result = new List<int>();

            DirectionEnum direction = DirectionEnum.LeftToRight;
            Demiliters delimiters = new Demiliters(matriz);

            while (!delimiters.Finished)
            {
                switch (direction)
                {
                    case DirectionEnum.LeftToRight:
                        for (int x = delimiters.Left; x <= delimiters.Right; x++)
                            result.Add(matriz[delimiters.Top, x]);

                        delimiters.Top++;
                        break;

                    case DirectionEnum.RightToBottom:
                        for (int y = delimiters.Top; y <= delimiters.Bottom; y++)
                            result.Add(matriz[y, delimiters.Right]);
                        delimiters.Right--;
                        break;

                    case DirectionEnum.BottomToLeft:
                        for (int x = delimiters.Right; x >= delimiters.Left; x--)
                            result.Add(matriz[delimiters.Bottom, x]);

                        delimiters.Bottom--;
                        break;

                    case DirectionEnum.LeftToTop:
                        for (int y = delimiters.Bottom; y >= delimiters.Top; y--)
                            result.Add(matriz[y, delimiters.Left]);

                        delimiters.Left++;
                        break;
                }

                direction = GetNextDirection(direction);
            }

            return result.ToArray();
        }

        private DirectionEnum GetNextDirection(DirectionEnum direction)
        {
            int x = (int)direction;
            x++;
            x = x % Enum.GetValues(typeof(DirectionEnum)).Length;
            DirectionEnum newEnum = (DirectionEnum)Enum.ToObject(typeof(DirectionEnum), x);

            return newEnum;
        }
    }
}
