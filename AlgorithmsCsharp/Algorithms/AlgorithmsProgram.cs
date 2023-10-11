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
        int[] inputArray = { 12, 11, 13, 5, 6, 7 };
        WriteLine("Input array: ");
        WriteArray(inputArray);
        WriteLine("Sorting with HeapSort...");
        HeapSort.Sort(inputArray);
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