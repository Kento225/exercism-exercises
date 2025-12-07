using System.Reflection.Metadata.Ecma335;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];

    public int Today() => birdsPerDay[6];

    public void IncrementTodaysCount() => birdsPerDay[6]++;

    public bool HasDayWithoutBirds()
    {
        foreach (var day in birdsPerDay)
        {
            if(day <= 0)
            {
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int currentDay = 0;
        int result = 0;

        while (currentDay < numberOfDays)
        {
            result += birdsPerDay[currentDay];
            currentDay++;
        }
        return result;
    }

    public int BusyDays()
    {
        int result = 0;
        foreach (var day in birdsPerDay)
        {
            if (day >= 5)
                result++;
        }
        return result;
    }
}
