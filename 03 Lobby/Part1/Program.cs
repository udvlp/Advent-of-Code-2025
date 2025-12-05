namespace AoC;

internal class Program
{
    static void Main()
    {
        var sr = new StreamReader(@"..\..\input.txt");
        int result = 0;
        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();
            int fv = -1;
            int fp = -1;

            for (int i = 0; i < line.Length-1; i++)
            {
                if (line[i] - '0' > fv)
                {
                    fv = line[i] - '0';
                    fp = i;
                }
            }

            int sv = -1;
            for (int i = fp+1; i < line.Length; i++)
            {
                if (line[i] - '0' > sv)
                {
                    sv = line[i] - '0';
                }
            }

            Console.WriteLine($"{fv} {sv}");

            result += fv * 10 + sv;

        }

        Console.WriteLine(result);
    }
}