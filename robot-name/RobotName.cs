using System;

public class Robot
{
    private static string name;
    Random rand = new Random(); //seading?
    private static int digit;
    //digit = 001; 
    //rand.Next(10); 

    public string Name
    {
        get  //how can I use this function? and do i need a set function as well?  
        {
            digit += 1; //int digit;
            digit = 100;
            for(int i = 0; i < 2; i++)
            {
                char randomChar = (char)rand.Next('a', 'z');
                //name.Insert(0,randomChar);
            }
   
            name = "AA";

            return String.Concat(name, digit); 
            //throw new NotImplementedException("You need to implement this function.");
        }
        //set
        //{
        //    name = value;
        //}
    }

    public void Reset()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
    
}
//Assert.Matches(@"^[A-Z]{2}\d{3}$", robot.Nasme);