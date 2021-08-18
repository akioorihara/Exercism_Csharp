using System;
using System.Collections.Generic;
using System.Linq;

public class Robot_old
{
    private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private Random Rand = new Random();

    public string Name
    {
        get
        {
            if (PastNames.Count == 0)
                return "";
            else
                return PastNames.Last();
        }
    }

    //Store past names used by the Robot.  We must ensure that all robot names generated are unique
    private static List<string> PastNames { get; set; } = new List<string>();

    public Robot_old()
    {
        //Constructor to set robot name during initialization
        Reset();
    }

    public void Reset()
    {
        PastNames.Add(GetNewName());
    }

    private string GetNewName()
    {
        string NewName;

        //There is a limited number of robot names using the format provided.
        //For do-while loop safety, we need to use a sentinel to ensure we do not use every robot name
        //Sentinels are used to help avoid inifinite looping
        //Find total # combinations-
        // 2 Random Chars A-Z * 3 Random Ints 0-9
        // (26 * 26) * (9 * 9 * 9) = 492,804

        //Initialize out sentinel
        int sentinel = 0;

        //Use a do-while loop to Generate the New Robot name, and confirm that it is unique (never been used as a past robot name)
        do
        {
            if (sentinel > 492804)
                throw new Exception("The total number of Robot Names has been reached!");

            NewName = Get2RandomChars() + Get3RandomInts();
            sentinel++;
        }
        while (PastNames.Contains(NewName));

        return NewName;
    }

    private char GetRandomChar()
    {
        //Use C# Random to generate a random number 0-25 (length of Alphabet)
        int i = Rand.Next(Alphabet.Length);

        //Return the character from Aplhabet at index
        return Alphabet[i];
    }

    private string Get2RandomChars()
    {
        //return string of 2 Random Chars together
        return GetRandomChar().ToString() + GetRandomChar().ToString();
    }

    private string Get3RandomInts()
    {
        //return string of 3 random ints together as string
        return Rand.Next(999).ToString().PadLeft(3,'0');
    }
}