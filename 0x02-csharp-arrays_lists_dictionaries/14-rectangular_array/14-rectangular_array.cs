using System;

class Program
{
    static void Main(string[] args)
    {
        int width = 5;
        int height = 5;
        int [,] matriz = new int[width, height];
        matriz [2, 2] = 1;

        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                if (y < height - 1){
                    Console.Write(matriz[x,y] + " ");
                }
                else {
                    Console.Write(matriz[x,y]);
                }
            }
            Console.WriteLine();
        }
    }
}
