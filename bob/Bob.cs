using System;

public static class Bob
{

    public static string Response(string statement)
    {
        statement = statement.Trim(' ');
        statement = statement.Trim('\t');
        statement = statement.Trim('\r');
        statement = statement.Trim('\n');

        statement = statement.Replace(" ", "");

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