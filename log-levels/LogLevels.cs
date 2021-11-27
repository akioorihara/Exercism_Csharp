using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        if (logLine.Contains("[ERROR]:"))
        {

            logLine.Replace("[ERROR]:", "");

            return logLine;

        }
        else
        {
            return "";
        }

        //throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        return logLine;
        //throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        return logLine;
        //throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
