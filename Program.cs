using System;
using System.Collections.Generic;

public class HedgehogColoring
{
    public static int MinMeetingsToUnify(int[] population, int targetColor)
    {
        bool isPopulation =
            (population[0] > 0 && population[1] == 0 && population[2] == 0 && targetColor == 0)
            || (population[1] > 0 && population[0] == 0 && population[2] == 0 && targetColor == 1)
            || (population[2] > 0 && population[0] == 0 && population[1] == 0 && targetColor == 2);

        if (isPopulation)
        {
            return 0;
        }

        Queue<(int R, int G, int B, int steps)> queue = new Queue<(int, int, int, int)>();
        queue.Enqueue((population[0], population[1], population[2], 0));

        HashSet<(int, int, int)> visited = new HashSet<(int, int, int)>();
        visited.Add((population[0], population[1], population[2]));

        // BFS
        while (queue.Count > 0)
        {
            var (R, G, B, steps) = queue.Dequeue();

            if (targetColor == 0 && G == 0 && B == 0)
                return steps;
            if (targetColor == 1 && R == 0 && B == 0)
                return steps;
            if (targetColor == 2 && R == 0 && G == 0)
                return steps;

            if (R > 0 && B > 0)
            {
                var newState = (R - 1, G + 1, B - 1);
                if (!visited.Contains(newState))
                {
                    visited.Add(newState);
                    queue.Enqueue((newState.Item1, newState.Item2, newState.Item3, steps + 1));
                }
            }

            if (R > 0 && G > 0)
            {
                var newState = (R - 1, G - 1, B + 1);
                if (!visited.Contains(newState))
                {
                    visited.Add(newState);
                    queue.Enqueue((newState.Item1, newState.Item2, newState.Item3, steps + 1));
                }
            }

            if (G > 0 && B > 0)
            {
                var newState = (R + 1, G - 1, B - 1);
                if (!visited.Contains(newState))
                {
                    visited.Add(newState);
                    queue.Enqueue((newState.Item1, newState.Item2, newState.Item3, steps + 1));
                }
            }
        }

        return -1;
    }

    public static void Main(string[] args)
    {
        int[] population = { 1, 1, 3 };
        int targetColor = 2;

        int result = MinMeetingsToUnify(population, targetColor);
        Console.WriteLine(result);
    }
}
