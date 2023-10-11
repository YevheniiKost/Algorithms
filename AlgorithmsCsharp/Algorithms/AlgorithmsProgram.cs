using System.Text;
using Algorithms.SortingAlgorithms;

namespace Algorithms;

public class AlgorithmsProgram
{
    public static void Run()
    {
        var program = new AlgorithmsProgram();
        Console.ReadLine();
    }

    private AlgorithmsProgram()
    {
        int[] inputArray = { 12, 11, 13, 5, 6, 7, 2, 1, 6, 19 };
        WriteLine("Input array: ");
        WriteArray(inputArray);
        WriteLine("Sorting with QuickSort...");
        QuickSort.Sort(inputArray);
        WriteArray(inputArray);
    }

    private void WriteArray(int[] inputArray)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("{ ");
        foreach (var item in inputArray)
        {
            sb.Append(item);
            sb.Append(", ");
        }
        sb.Append(" }");
        WriteLine(sb.ToString());
    }

    private void WriteLine(string line)
    {
        Console.WriteLine(line);
    }
}