using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        int[,] matriz = myMatrix.Clone() as int[,];
        for (int i = 0; i < myMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < myMatrix.GetLength(1); j++)
            {
                matriz[i, j] *= matriz[i, j];
            }
        }
        return matriz;
    }
}
