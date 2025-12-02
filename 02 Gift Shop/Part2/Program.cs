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
                    int idlen = idstr.Length;

                    for (int seglen = 1; seglen <= idlen / 2; seglen++)
                    {
                        if (idlen % seglen == 0)
                        {
                            string seg = idstr.Substring(0, seglen);
                            bool b = true;
                            for (int j = seglen; j < idlen; j += seglen)
                            {
                                if (idstr.Substring(j, seglen) != seg)
                                {
                                    b = false;
                                    break;
                                }
                            }
                            if (b)
                            {
                                result += id;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}