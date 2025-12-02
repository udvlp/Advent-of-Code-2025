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
            Console.WriteLine($"Line: {line}");
            int value = int.Parse(line.Substring(1));
            int rounds = value / 100;
            value %= 100;
            if (rounds > 0)
            {
                result += rounds;
            }
            if (line[0] == 'L') value = -value;
            if (dial + value == 0)
            {
                result++;
            }
            else if (dial + value < 0)
            {
                if (dial != 0) result++;
                dial += 100;
            }
            else if (dial + value >= 100)
            {
                dial -= 100;
                result++;
            }
            dial += value;
    
            Console.WriteLine($"Dial: {dial}");
        }

        Console.WriteLine($"Result: {result}");

    }
}