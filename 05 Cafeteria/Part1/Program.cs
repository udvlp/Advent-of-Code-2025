namespace AoC;

internal class Program
{
    static void Main()
    {
        var sr = new StreamReader(@"..\..\input.txt");
        int result = 0;
        List<(long min, long max)> ranges = new();
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            if (line == "") break;
            string[] p = line.Split('-');
            ranges.Add((long.Parse(p[0]), long.Parse(p[1])));
        }

        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            long num = long.Parse(line);
            foreach (var (min, max) in ranges)
            {
                if (num >= min && num <= max)
                {
                    result++;
                    break;
                }
            }
        }
        Console.WriteLine(result);
    }
}