namespace AoC;

internal class Program
{
    static void Main()
    {
        checked
        {
            long result = 0;
            var sr = new StreamReader(@"..\..\input.txt");
            string line = sr.ReadLine();

            string[] ranges = line.Split(',', StringSplitOptions.RemoveEmptyEntries);
            foreach (var range in ranges)
            {
                string[] bounds = range.Split('-', StringSplitOptions.RemoveEmptyEntries);
                long start = long.Parse(bounds[0]);
                long end = long.Parse(bounds[1]);
                for (long id = start; id <= end; id++)
                {
                    string idstr = id.ToString();
                    if (idstr.Length % 2 == 0)
                    {
                        if (idstr.Substring(0, idstr.Length / 2) == idstr.Substring(idstr.Length / 2))
                        {
                            result += id;
                        }
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}