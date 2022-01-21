using System;

public static class EntMethods
{

<<<<<<< HEAD
    public static string Response(string statement)
    {
=======
    /// <summary>
    /// Remove all instances of ToRemove with empty srting
    /// </summary>
    /// <param name="In"></param>
    /// <param name="ToRemove">The String to remove</param>
    /// <returns></returns>
    public static string RemoveIt(this string In, string ToRemove)
    {
        return In.Replace(ToRemove, "");
    }
}

public static class Bob
{ 

    public static string Response(string statement)
    {
        statement = statement.Trim();
>>>>>>> a16b768124f165a8bd00ade7b955c019036a4aa9
        statement = statement.Trim(' ');
        statement = statement.Trim('\t');
        statement = statement.Trim('\r');
        statement = statement.Trim('\n');
<<<<<<< HEAD

        statement = statement.Replace(" ", "");
=======
        statement = statement.Replace(" ", "");
        statement = statement.Replace("\n", "");

        statement = statement.RemoveIt(" ");

        if (statement.Trim().Length == 0)
        {

        }

        //statement = " "; // the diff from the above codes 
>>>>>>> a16b768124f165a8bd00ade7b955c019036a4aa9

        if (statement == "")
        {
            return "Fine. Be that way!";
        }
<<<<<<< HEAD

=======
>>>>>>> a16b768124f165a8bd00ade7b955c019036a4aa9
        else if (isAllUpper(statement))
        {
            //yell a question 
            if (statement.Contains("?"))
                return "Calm down, I know what I'm doing!";
            return "Whoa, chill out!";
        }
<<<<<<< HEAD

=======
>>>>>>> a16b768124f165a8bd00ade7b955c019036a4aa9
        //Question 
        else if (isQuestion(statement))
        {
            return "Sure.";
        }
<<<<<<< HEAD
        
=======

>>>>>>> a16b768124f165a8bd00ade7b955c019036a4aa9
        //Anything else 
        else
        {
            return "Whatever.";
        }
        //throw new NotImplementedException("You need to implement this function.");
<<<<<<< HEAD
    }

    public static bool isAllUpper(string statement)
    {
        for(int i = 0; i < statement.Length; i++)
        {
            if (!Char.IsUpper(statement[i]))

             //I have to skip the special char and digit here 
             //&& !char.IsSymbol(statement[i]) && !char.IsNumber(statement[i]) )
            {
                return false; 
            }
        }
        return true;
    }

    public static bool isQuestion(string statement)
    {
        if (statement[statement.Length-1] == '?')
            return true; 
        return false; 
    }

}
=======
    }

    private const string Alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    //private const string Punctuation = "?!.;:";

    private static bool isAllUpper(string statement)
    {
        for (int i = 0; i < statement.Length; i++)
        {
            if (Alphabet.Contains(statement[i]))
            {
                if (!Char.IsUpper(statement[i]))
                //I have to skip the special char and digit here 
                //&& !char.IsSymbol(statement[i]) && !char.IsNumber(statement[i]) )
                {
                    return false;
                }
            }

        }
        return true;
    }
    private static bool isQuestion(string statement)
    {
        if (statement[statement.Length - 1] == '?')
            return true;
        return false;
    }
}
>>>>>>> a16b768124f165a8bd00ade7b955c019036a4aa9
