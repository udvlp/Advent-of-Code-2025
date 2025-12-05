namespace AoC;

internal class Program
{
    static void Main()
    {
        long result = 0;

        List<(long min, long max)> ranges = new();
        var sr = new StreamReader(@"..\..\input.txt");
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            if (line == "") break;
            string[] p = line.Split('-');
            ranges.Add((long.Parse(p[0]), long.Parse(p[1])));
        }

        ranges.Sort();

        List<(long min, long max)> merged = new();
        merged.Add(ranges[0]);

        foreach (var r in ranges)
        {
            var last = merged[^1];
            if (r.min <= last.max + 1)
            {
                merged[^1] = (last.min, Math.Max(last.max, r.max));
            }
            else
            {
                merged.Add(r);
            }
        }

        foreach (var r in merged)
        {
            result += r.max-r.min+1;
        }

        Console.WriteLine(result);
    }
}