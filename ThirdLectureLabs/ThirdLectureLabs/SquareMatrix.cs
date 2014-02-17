using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLectureLabs
{
    class SquareMatrix
    {
        public  int[,] Matrix;

        public int Size { get; private set; }


    
        public  SquareMatrix(int size)
        {
            if (size <= 0) throw new Exception();//TODO write an exeption
            else
            {
                Size = size;
                Matrix = new int[size, size];
                var rnd = new Random();
                for (int i = 0; i < size;i++)
                    for (int j = 0; j < size; j++)
                    {
                        Matrix[i, j] = rnd.Next();
                    }
                 
            }
        }

        public override string ToString()
        {
            var result = "";
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    result += Matrix[i, j].ToString() + " ";
                }
                result += "/n";
            }
            return result;
        }

        public static SquareMatrix operator +(SquareMatrix a,SquareMatrix b)
        {
            if (a.Size != b.Size) throw new Exception();//TODO write an exeption
            var size = a.Size;
            var result = new SquareMatrix(size);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result.Matrix[i, j] = a.Matrix[i, j] + b.Matrix[i, j];
                }
               
            }
        }
    }
}
