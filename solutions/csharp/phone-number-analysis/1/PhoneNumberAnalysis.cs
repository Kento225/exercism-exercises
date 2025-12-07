using System.Reflection;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        string[] numberArr = phoneNumber.Split('-');
        return ( numberArr[0].Equals("212"), numberArr[1].Equals("555"), numberArr[2] );
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
