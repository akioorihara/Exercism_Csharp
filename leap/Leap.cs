using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        if(year % 4 == 0)
        {
                if (year % 100 == 0 && year % 400 == 0)
                {
                    return true;
                }
                else if (year % 100 == 0)
                    return false;
                else
                    return true;
        }
            else
                return false;
        //throw new NotImplementedException("You need to implement this function.");
    }
}