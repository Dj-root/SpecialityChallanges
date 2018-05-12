using System;
using System.Runtime.CompilerServices;

namespace CSharp.Essential.Unit5
{
    public class MyMatrix
    {
        private int[,] matrix;

//        private int rowsQty, colsQty;
        public int RowsQty { get; private set; }
        public int ColsQty { get; private set; }

        public MyMatrix(int rows, int cols)
        {
            Random r = new Random();

            if (rows != 0 & cols != 0)
            {
                RowsQty = rows;
                ColsQty = cols;
                this.matrix = new int[RowsQty, ColsQty];

                for (int i = 0; i < RowsQty; i++)
                {
                    for (int j = 0; j < ColsQty; j++)
                    {
                        this.matrix[i, j] = r.Next(-100, 100);
                    }
                }
            }
            else
            {
                ColsQty = ColsQty = 1;
                this.matrix = new int[1, 1];
                this.matrix[0, 0] = r.Next(-100, 100);
            }
        }

        public int this[int rows, int cols]
        {
            get { return matrix[rows, cols]; }
            set { matrix[rows, cols] = value; }
        }


        public void PrintMatrix()
        {
            Console.WriteLine("Printing matrix with {0} elements, {1} Rows and {2} columns",
                this.matrix.Rank, this.RowsQty, this.ColsQty);
//            Console.WriteLine(matrix.matrix.);
            if (ColsQty == 1 & RowsQty == 0)
            {
                Console.Write("\t| {0,2} |", this.matrix[0, 0]);
            }
            else
            {
                for (int i = 0; i < RowsQty; i++)
                {
                    for (int j = 0; j < ColsQty; j++)
                    {
                        Console.Write("\t| {0,2} |", this.matrix[i, j]);
                    }

                    Console.WriteLine();
                }
            }
        }


        public void ResizeMartix(int rows, int cols)
        {
            Random r = new Random();
            int[,] tmpMtrx = new int[rows, cols];

            if (RowsQty >= rows && ColsQty >= cols)
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        tmpMtrx[i, j] = this.matrix[i, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (i < RowsQty & j < ColsQty)
                        {
                            tmpMtrx[i, j] = this.matrix[i, j];
                        }
                        else
                        {
                            tmpMtrx[i, j] = r.Next(-100, 100);
                        }
                    }
                }
            }

            RowsQty = rows;
            ColsQty = cols;
            this.matrix = tmpMtrx;
        }
    }
}