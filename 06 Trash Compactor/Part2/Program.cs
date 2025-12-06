namespace AoC;

internal class Program
{
    static void Main()
    {
        long result = 0;
        
        List<char[]> lines = new();
        var sr = new StreamReader(@"..\..\input.txt");
        int maxlen = 0;
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            lines.Add(line.ToCharArray());
            if (line.Length > maxlen) maxlen = line.Length;
        }

        List<long> values = new();
        for (int x = maxlen - 1; x >= 0; x--)
        {
            long v = 0;
            for (int y = 0; y < lines.Count - 1; y++)
            {
                int d = 0;
                if (x < lines[y].Length && lines[y][x] != ' ')
                {
                    d = lines[y][x] - '0';
                    v = v * 10 + d;
                }
            }
            values.Add(v);
            if (x < lines[^1].Length && lines[^1][x] != ' ')
            {
                long r = 0;
                if (lines[^1][x] == '+')
                {
                    foreach (var val in values)
                    {
                        r += val;
                    }
                }
                else if (lines[^1][x] == '*')
                {
                    r = 1;
                    foreach (var val in values)
                    {
                        r *= val;
                    }
                }
                values.Clear();
                x--;
                result += r;
            }

        }
        
        Console.WriteLine(result);
    }
}