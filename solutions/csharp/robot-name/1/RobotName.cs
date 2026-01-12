public class Robot
{
    public static List<string> SerialNumbers = new List<string>();

    public static Random random = new Random();

    public string name = string.Empty;
    public string Name
    {
        get
        {
            return name == string.Empty ? GetSerialNumber() : name;
        }
    }

    public void Reset()
    {
        name = GetSerialNumber();
    }

    public string GetRandomNumber() => random.Next(100, 999).ToString();

    public char GetRandomUppercaseLetter() => (char)random.Next('A', 'Z' + 1);

    public string GetSerialNumber()
    {
        bool nameIsUnique = false;
        var serialNumber = string.Empty;

        while (!nameIsUnique)
        {
            serialNumber = string.Empty;
            serialNumber = $"{GetRandomUppercaseLetter()}{GetRandomUppercaseLetter()}{GetRandomNumber()}";
            nameIsUnique = !SerialNumbers.Contains(serialNumber);
        }

        SerialNumbers.Add(serialNumber);
        name = serialNumber;
        return serialNumber;
    } 
}