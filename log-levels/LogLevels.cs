using System;

static class LogLine
{
    public static string GetResult(string logLine, string logLevel)
    {
        string result = "";
        int i = logLine.IndexOf(logLevel);
        result = logLine.Remove(i, logLevel.Length);
        result = result.Trim();
        return result;
    }

    public static string Message(string logLine)
    {
        string info_= "[INFO]:";
        string waring_ = "[WARNING]:";
        string error_ = "[ERROR]:";
        string result = "";


        if (logLine.Contains(error_))
        {
            //return GetResult(logLine, error_);
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
        string toLow = logLine.ToLower();
        //string result = "";
        if (toLow.Contains("error"))
        {
            //result = toLow.IndexOf("\[");
            //result = result.Trim();
            return "error";
        }
        else if (toLow.Contains("info"))
        {
            return "info";

        }
        else if (toLow.Contains("warning"))
        {
            return "warning";

        }
        else
        {
            //Console.WriteLine("Not Found");
            return "";
        }


        //throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string info_ = "[INFO]:";
        string waring_ = "[WARNING]:";
        string error_ = "[ERROR]:";
        string result = "";

        if (logLine.Contains(error_))
        {
            int i = logLine.IndexOf(error_);
            result = logLine.Remove(i, error_.Length);
            result = result.Trim();
            int len = result.Length;
            result = result.Insert(len, " (error)");
            return result;
        }
        else if (logLine.Contains(info_))
        {
            int i = logLine.IndexOf(info_);
            result = logLine.Remove(i, info_.Length);
            result = result.Trim();
            int len = result.Length;
            result = result.Insert(len, " (info)");
            return result;
            return result;

        }
        else if (logLine.Contains(waring_))
        {
            int i = logLine.IndexOf(waring_);
            result = logLine.Remove(i, waring_.Length);
            result = result.Trim();
            int len = result.Length;
            result = result.Insert(len, " (warning)");
            return result;
        }
        else
        {
            //Console.WriteLine("Not Found");
            return "";
        }





        return logLine;
        //throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
