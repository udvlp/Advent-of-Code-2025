namespace AoC;

internal class Program
{
    static void Main()
    {
        int result = 0;

        HashSet<int> beams = new();
        var sr = new StreamReader(@"..\..\input.txt");
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            if (beams.Count == 0)
            {
                beams.Add(line.IndexOf('S'));
            }
            else
            {
                HashSet<int> next = new();
                foreach (int b in beams)
                {
                    if (line[b] == '^')
                    {
                        next.Add(b - 1);
                        next.Add(b + 1);
                        result++;
                    }
                    else
                    {
                        next.Add(b);
                    }
                }
                beams = next;
            }
        }

        Console.WriteLine(result);
    }
}