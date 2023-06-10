using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        var x = 0;
        for(int i = 1; i <= max; i++)
        {
            x += i;
        }
        return x * x;
     }

    public static int CalculateSumOfSquares(int max)
    {
        int sumOfSquares = 0;
        for (int i = 1; i <= max; i++)
        {
            sumOfSquares += Convert.ToInt32(Math.Pow(i, 2)); 
        }
        return sumOfSquares;
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}