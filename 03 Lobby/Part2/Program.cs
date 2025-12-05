namespace AoC;

internal class Program
{
    static void Main()
    {
        var sr = new StreamReader(@"..\..\input.txt");
        long result = 0;
        while (!sr.EndOfStream)
        {
            long jolt = 0;
            var line = sr.ReadLine();

            int l = line.Length;
            int r = 0;
            for (int b = 12; b > 0; b--)
            {
                int m = -1;
                for (int i = r; i < l - b + 1; i++)
                {
                    if (line[i] - '0' > m)
                    {
                        m = line[i] - '0';
                        r = i + 1;
                    }
                }
                jolt = jolt * 10 + m;
            }

            result += jolt;

        }

        Console.WriteLine(result);
    }
}