using System;
public static class Darts
{
    public static int Score(double x, double y)
    {
        double distance = Distance(x, y);
        if (distance <= 1)
            return 10;
        else if (distance <= 5)
            return 5;
        else if (distance <= 10)
            return 1;
        else
            return 0;
    }
    private static double Distance(double x, double y)
    {
        return System.Math.Sqrt(x * x + y * y);
    }
}