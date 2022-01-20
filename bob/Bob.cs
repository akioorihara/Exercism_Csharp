using System;

public static class EntMethods
{

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
        statement = statement.Trim(' ');
        statement = statement.Trim('\t');
        statement = statement.Trim('\r');
        statement = statement.Trim('\n');
        statement = statement.Replace(" ", "");
        statement = statement.Replace("\n", "");

        statement = statement.RemoveIt(" ");

        if (statement.Trim().Length == 0)
        {

        }

        //statement = " "; // the diff from the above codes 

        if (statement == "")
        {
            return "Fine. Be that way!";
        }
        else if (isAllUpper(statement))
        {
            //yell a question 
            if (statement.Contains("?"))
                return "Calm down, I know what I'm doing!";
            return "Whoa, chill out!";
        }
        //Question 
        else if (isQuestion(statement))
        {
            return "Sure.";
        }

        //Anything else 
        else
        {
            return "Whatever.";
        }
        //throw new NotImplementedException("You need to implement this function.");
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
