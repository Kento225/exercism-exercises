static class LogLine
{
    static string[] LogLevels = ["[INFO]", "[WARNING]", "[ERROR]"];


    public static string Message(string logLine)
    {
        string result = string.Empty;
        foreach (var logLevel in LogLevels)
        {
            if (logLine.Contains(logLevel))
            {
                result = logLine.Substring(logLevel.Length + 1);
                result = result.Trim();
            }
        }
        return result;
    }

    public static string LogLevel(string logLine)
    {
        string result = string.Empty;
        foreach (var logLevel in LogLevels)
        {
            if(logLine.Contains(logLevel))
            {
                result = logLevel.ToLower().TrimStart('[').TrimEnd(']');
            }
        }
        return result;
    }

    public static string Reformat(string logLine)
    {
        string text = Message(logLine);
        string log = LogLevel(logLine);
        return $"{text} ({log})";
    }
}
