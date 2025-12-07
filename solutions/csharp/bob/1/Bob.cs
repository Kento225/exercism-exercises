public static class Bob
{
    public static string Response(string statement)
    {
        statement = statement.Trim();

        if (IsYellingQuestion(statement))
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (IsYelling(statement))
        {
            return "Whoa, chill out!";
        }
        else if (IsQuestion(statement))
        {
            return "Sure.";
        }
        else if (IsSilence(statement))
        {
            return "Fine. Be that way!";
        }
        return "Whatever.";
    }

    public static bool IsQuestion(string statement) => statement.EndsWith('?');
    public static bool IsYelling(string statement) => statement.Any(char.IsLetter) && statement.Where(char.IsLetter).All(Char.IsUpper);
    public static bool IsYellingQuestion(string statement) => IsQuestion(statement) && IsYelling(statement);
    public static bool IsSilence(string statement) => statement.All(Char.IsWhiteSpace) || statement == "";

}