public static class LogAnalysis
{
    // TODO: define the '' extension method on the `string` type
    public static string[] LogLevels = ["[INFO]", "[WARNING]", "[ERROR]"];

    public static string SubstringAfter(this string log, string delimiter)
    {
        return log.Substring(log.IndexOf(delimiter) + delimiter.Length);
    }

    public static string SubstringBetween(this string log, string delimiterStart, string delimiterEnd)
    {
        int indexOne = log.IndexOf(delimiterStart);
        int indexTwo = log.IndexOf(delimiterEnd);

        string result = log.Substring(indexOne + delimiterStart.Length, indexTwo - indexOne - delimiterStart.Length);
        return result;


    }
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string log)
    {
        string result = string.Empty;
        foreach (var logLevel in LogLevels)
        {
            if (log.Contains(logLevel))
            {
                result = log.Substring(log.IndexOf(logLevel)+logLevel.Length + 2);
                    break;
            }
        }
        return result;
    }
    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string log)
    {
        string result = string.Empty;
        foreach (var logLevel in LogLevels)
        {
            if (log.Contains(logLevel))
            {
                result = logLevel.TrimStart('[').TrimEnd(']');
            }
        }
        return result;
    }
}