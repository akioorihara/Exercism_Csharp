using System;

public class Robot
{
    //public static string name;
    Random rand = new Random();
    rand.Next(10); 

    public string Name
    {
        //var rand = new Random();
        get
        {
            return Name; 
            //throw new NotImplementedException("You need to implement this function.");
        }
    }

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}


//Assert.Matches(@"^[A-Z]{2}\d{3}$", robot.Name);