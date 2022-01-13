using System;

public static class Triangle
{
    //An equilateral triangle has all three sides the same length.

    //An isosceles triangle has at least two sides the same length.
    //(It is sometimes specified as having exactly two sides the same length, but for the purposes of this exercise we'll say at least two.)

    //A scalene triangle has all sides of different lengths

    //For a shape to be a triangle at all, all sides have to be of length > 0,
    //and the sum of the lengths of any two sides must be greater than or equal to the length of the third side.See

    //The case where the sum of the lengths of two sides equals that of the third is known as a degenerate triangle
    //It has zero area and looks like a single line. Feel free to add your own code/tests to check for degenerate triangles.

    public static bool checker(double side1, double side2, double side3)
    {
        //Check if lengths are greater than 0 && violation 
        if(side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            return false;
        }

        //Check the sum of the lengths of any two sides must be greater than equal to the length of the third side 
        //is there anyway I could loop through to check 3 vars?
        double case1 = side1 + side2, case2 = side1 + side3, case3 = side2 + side3;
        if(case1 < side3 || case2 < side2 || case3 < side1)
        {
            return false;
        }

        return true; 
    }

    public static bool IsScalene(double side1, double side2, double side3)
    {
        //Assert.True(Triangle.IsScalene(5, 4, 6));
        //Assert.False(Triangle.IsScalene(7, 3, 2)); //violation

        //Check if lengths are greater than 0 && violation 
        bool b = checker(side1, side2, side3);
        if (b == false)
        {
            return false;
        }

        //
        bool x = IsIsosceles(side1, side2, side3);
        return !x;


    }

    public static bool IsIsosceles(double side1, double side2, double side3) 
    {
        //Check if lengths are greater than 0 && violation 
        bool b = checker(side1, side2, side3);
        if (b == false)
        {
            return false;
        }

        //Compare with lengths 
        int counter = 0;
        if(side1 == side2)
        {
            counter++;
        }
        if(side1 == side3)
        {
            counter++;
        }
        if(side2 == side3)
        {
            counter++;
        }

        //
        if (counter >= 1)
        {
            return true;

        }
        else
        {
            return false;
        }

    }

    public static bool IsEquilateral(double side1, double side2, double side3) 
    {
        bool b = checker(side1,side2,side3);
        //how can I make it inline if_statement for this? 
        if(b == false)
        {
            return false; 
        }

        if (side1 == side2 && side1 == side3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}