using System;
using System.Collections.Generic;

public class Robot
{
    private static string name;
    private static int digit;
    private static List<string> list = new List<string>();

    Random rand = new Random(); //seading

    //public string Name
    //{
    //    get  //how can I use this function? and do i need a set function as well?  
    //    {
    //        //name = "AA";
    //        //digit = 100;
    //        //digit += 1; 

    //        //return String.Concat(name, digit);
    //        if (name is null)
    //            getNames();
    //        return name; 
    //    }
    //    //set
    //    //{
    //    //    name = value;
    //    //}
    //}

    public string Name;

    public Robot()
    {
        Name = getNames();
    }


    private string getNames()
    {
        //for(int i = 0; i < 2; i++)
        //{
        //    name += ((char)(rand.Next(1, 26) + 64)).ToString().ToUpper();
        //}
        //digit = rand.Next(100, 999);
        if (!list.Contains(name))
        {
            name = "AA";
            digit = 100;
            digit++;

        }




        string NewName = GenerateName();

        while (list.Contains(NewName))
        {
            NewName = GenerateName();
        }
        list.Add(NewName);

        return NewName;

        //return name = String.Concat(name, digit);
    }

    public string GenerateName()
    {
        string Char1 = ((char)(rand.Next(1, 26) + 64)).ToString().ToUpper();
        string Char2 = ((char)(rand.Next(1, 26) + 64)).ToString().ToUpper();
        int digit = rand.Next(100, 999);

        return Char1 + Char2 + digit.ToString();
    }

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
    
}
//Assert.Equal(robot.Name, robot.Name);