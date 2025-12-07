public static class Identifier
{
    public static string Clean(string identifier)
    {
        string GreekLetters = "αβγδεζηθικλμνξοπρστυφχψω";

        if (identifier.Contains('-'))
        {
            char charToCamel = identifier[identifier.IndexOf("-") + 1];
            char upperCharToCamel = Char.ToUpper(charToCamel);
            identifier = identifier.Replace(charToCamel, upperCharToCamel);
        }

        identifier = identifier.Replace(' ', '_').Replace("\0", "CTRL").Replace("-", "");
        identifier = string.Concat(identifier.Where(c => (c == '_' || char.IsLetter(c)) && !GreekLetters.Contains(c)));
        return identifier;

    }
}
