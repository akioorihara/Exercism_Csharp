using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        return moment.AddSeconds(1000000000);   
        // throw new NotImplementedException("You need to implement this function.");
    }
}