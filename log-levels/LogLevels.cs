using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        string info_= "[INFO]:";
        string waring_ = "[WARNING]:";
        string error_ = "[ERROR]:";
        string result = "";

        if (logLine.Contains(error_))
        {
            int i = logLine.IndexOf(error_);
            result = logLine.Remove(i, error_.Length);
            result = result.Trim();
            return result; 
        }
        else if (logLine.Contains(info_))
        {
            int i = logLine.IndexOf(info_);
            result = logLine.Remove(i, info_.Length);
            result = result.Trim();
            return result;

        }
        else if (logLine.Contains(waring_))
        {
            int i = logLine.IndexOf(waring_);
            result = logLine.Remove(i, waring_.Length);
            result = result.Trim();
            return result;

        }
        else
        {
            //Console.WriteLine("Not Found");
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
