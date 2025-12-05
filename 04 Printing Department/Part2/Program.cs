namespace AoC;

internal class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines(@"..\..\input.txt");
        bool[,] map = new bool[lines.Length + 2, lines[0].Length + 2];

        for (int y = 0; y < lines.Length; y++)
        {
            for (int x = 0; x < lines[y].Length; x++)
            {
                map[y + 1, x + 1] = lines[y][x] == '@';
            }
        }

        int result = 0;

        while (true)
        {
            bool changed = false;
            bool[,] nextmap = new bool[map.GetLength(0), map.GetLength(1)];
            for (int y = 1; y < map.GetLength(0) - 1; y++)
            {
                for (int x = 0; x < map.GetLength(1) - 1; x++)
                {
                    if (map[y, x])
                    {
                        int adjacent = 0;
                        for (int dy = -1; dy <= 1; dy++)
                        {
                            for (int dx = -1; dx <= 1; dx++)
                            {
                                if (dx == 0 && dy == 0) continue;
                                if (map[y + dy, x + dx])
                                {
                                    adjacent++;
                                }
                            }
                        }

                        if (adjacent < 4)
                        {
                            result++;
                            changed = true;
                        }
                        else
                        {
                            nextmap[y, x] = true;
                        }
                    }
                }
            }
            if (!changed) break;
            map = nextmap;
        }
     
        Console.WriteLine(result);
    }
}