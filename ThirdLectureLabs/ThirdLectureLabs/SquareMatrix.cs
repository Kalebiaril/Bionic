using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLectureLabs
{
    internal class SquareMatrix : IComparable,ICloneable
    {
        public int[,] Matrix;

        public int Size { get; private set; }

        public int Determinant { get; private set; }


        public SquareMatrix(int size)
        {
            try
            {
                if (size <= 0) throw new NegativeMatrixSizeException(); //TODO write an exeption
                else
                {
                    Size = size;
                    Matrix = new int[size, size];
                    var rnd = new Random();
                    for (int i = 0; i < size; i++)
                        for (int j = 0; j < size; j++)
                        {
                            Matrix[i, j] = rnd.Next(-10,10);
                        }
                    Determinant = CalculateDeterminant(size);
                }
            }
            catch (NegativeMatrixSizeException ex)
            {
                Matrix = new int[1, 1];
                Matrix[0, 0] = 0;
                Determinant = 0;
                Console.WriteLine(ex.Message);
            }
           
        }
        public SquareMatrix()
        {        
            Matrix = new int[1, 1];
            Matrix[0, 0] = 0;
            Determinant = 0;
        }
        private int CalculateDeterminant(int size)
        {
            return 0;
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
                result += "\n";
            }
            return result;
        }

        public static SquareMatrix operator +(SquareMatrix a, SquareMatrix b)
        {
            try
            {
                if (a.Size != b.Size) throw new DifferentMatrixSizeException();
                var size = a.Size;
                var result = new SquareMatrix(size);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        result.Matrix[i, j] = a.Matrix[i, j] + b.Matrix[i, j];
                    }

                }
                return result;
            }
            catch (DifferentMatrixSizeException ex)
            {
               Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static SquareMatrix operator -(SquareMatrix a, SquareMatrix b)
        {
            try
            {
                if (a.Size != b.Size) throw new DifferentMatrixSizeException();
                var size = a.Size;
                var result = new SquareMatrix(size);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        result.Matrix[i, j] = a.Matrix[i, j] - b.Matrix[i, j];
                    }

                }
                return result;
            }
            catch (DifferentMatrixSizeException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public static bool operator == (SquareMatrix a, SquareMatrix b)
        {
            try
            {
                if (a.Size != b.Size) throw new DifferentMatrixSizeException();
                var size = a.Size;

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (a.Matrix[i, j] != b.Matrix[i, j]) return false;
                    }

                }
                return true;
            }
            catch (DifferentMatrixSizeException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool operator !=(SquareMatrix a, SquareMatrix b)
        {
            try
            {
                if (a.Size != b.Size) throw new DifferentMatrixSizeException();
                var size = a.Size;
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (a.Matrix[i, j] != b.Matrix[i, j]) return true;
                    }
                }
                return false;
            }
            catch (DifferentMatrixSizeException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is SquareMatrix)
            {
                var squareMatrix = obj as SquareMatrix;
                if (Size != squareMatrix.Size) return false;
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        if (squareMatrix.Matrix[i, j] != Matrix[i, j]) return false;
                    }
                }
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Determinant;
        }


        public static bool operator true(SquareMatrix squareMatrix)
        {
            if (squareMatrix.Determinant == 0) return false;
            return true;
        }

        public static bool operator false(SquareMatrix squareMatrix)
        {
            if (squareMatrix.Determinant == 0) return true;
            return false;
        }

        public int CompareTo(object obj)
        {
            if (obj is SquareMatrix)
            {
                var squareMatrix = obj as SquareMatrix;
                if (Size > squareMatrix.Size) return 1;
                if (Size < squareMatrix.Size) return -1;
                if (Size == squareMatrix.Size) return 0;
            }
            else throw new Exception(); //TODO
            return -1;
        }

        public object Clone()
        {
            SquareMatrix result = new SquareMatrix(Size);
            result.Matrix = Matrix;
            result.Determinant = Determinant;
            result.Size = Size;
            return result;
        }
       }

    class  DifferentMatrixSizeException:Exception
    {
        public DifferentMatrixSizeException() : base()
        {
        }

        public DifferentMatrixSizeException(string  message):base(message)
        {
        }
        public DifferentMatrixSizeException(string message, Exception inner)
            : base(message,inner)
        {
        }
    }
    class NegativeMatrixSizeException : Exception
    {
        public NegativeMatrixSizeException()
            : base()
        {
        }

        public NegativeMatrixSizeException(string message)
            : base(message)
        {
        }
        public NegativeMatrixSizeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

}
