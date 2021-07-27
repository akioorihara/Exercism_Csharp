using System;

public static class ResistorColor
{
    public static int ColorCode(string color)
    {
        color.ToLower();
        if (color == "black")
            return 0;
        else if (color == "brown")
            return 1;
        else if (color == "red")
            return 2;
        else if (color == "red")
            return 3;
        else if (color == "yellow")
            return 4;
        else if (color == "green")
            return 5; 
        else if (color == "blue")
            return 6;
        else if (color == "violet")
            return 7;
        else if (color == "grey")
            return 8;
        else
            return 9; 
        //throw new NotImplementedException("You need to implement this function.");
    }

    public static string[] Colors()
    {
        string [] ColorString = new string [] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
        return ColorString;
        //throw new notimplementedexception("you need to implement this function.");
    }
}