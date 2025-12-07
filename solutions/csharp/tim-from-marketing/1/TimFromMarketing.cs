using System.Reflection.Metadata.Ecma335;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string idText = id is not null ? $"[{id}] - " : string.Empty;
        string departmentText = department is null ? "OWNER" : department.ToUpper();
        return $"{idText}{name} - {departmentText}";
    } 
}
