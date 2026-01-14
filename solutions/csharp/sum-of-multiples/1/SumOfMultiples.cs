public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> numbers = new List<int>();

        foreach (var multiple in multiples.Distinct().Where(x => x > 0)) {
            int number = 0;

            while (number <= max) {
                number += multiple;
                if (number < max) {
                    numbers.Add(number);
                }
            }

        }

        return numbers.Distinct().Sum();
    }
}