namespace AoC;

internal class Program
{
    static void Main()
    {
        Dictionary<int, long> beams = new();
        var sr = new StreamReader(@"..\..\input.txt");
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            if (beams.Count == 0)
            {
                beams.Add(line.IndexOf('S'), 1);
            }
            else
            {
                Dictionary<int, long> next = new();
                foreach (var b in beams)
                {
                    if (line[b.Key] == '^')
                    {
                        if (!next.TryAdd(b.Key - 1, b.Value)) next[b.Key - 1] += b.Value;
                        if (!next.TryAdd(b.Key + 1, b.Value)) next[b.Key + 1] += b.Value;
                    }
                    else
                    {
                        if (!next.TryAdd(b.Key, b.Value)) next[b.Key] += b.Value;
                    }
                }
                beams = next;
            }
        }

        long result = 0;
        foreach (var b in beams)
        {
            result += b.Value;
        }

        Console.WriteLine(result);
    }
}