namespace AoC;

internal class Program
{
    static void Main()
    {
        long result = 0;
        List<string[]> lines = new();
        var sr = new StreamReader(@"..\..\input.txt");
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            lines.Add(line.Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries));
        }

        for (int x = 0; x < lines[0].Length; x++)
        {
            char op = lines[^1][x][0];

            long r = long.Parse(lines[0][x]);
            for (int y = 1; y < lines.Count - 1; y++)
            {
                long v = long.Parse(lines[y][x]);
                if (op == '+')
                {
                    r += v;
                }
                else if (op == '*')
                {
                    r *= v;
                }
            }
            result += r;
        }

        Console.WriteLine(result);
    }
}