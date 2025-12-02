namespace AoC;

internal class Program
{
    static void Main()
    {
        var sr = new StreamReader(@"..\..\input.txt");
        int result = 0;
        int dial = 50;
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            int value = int.Parse(line.Substring(1));
            if (line[0] == 'L') value = -value;
            dial = (dial + value) % 100;
            if (dial < 0) dial += 100;
            if (dial == 0) result++;
        }

        Console.WriteLine($"Result: {result}");
    }
}