using System;
using System.Collections.Generic;
public class Soluation
{
    public static int[] TwoSum(int[] arr, int target)
    {
      Dictionary<int, int> map = new Dictionary<int, int>();

       for(int i=0; i<arr.Length; i++)
        {
            int diffrence = target - arr[i];
            if(map.ContainsKey(diffrence))
            {
                int FirstIndex = map[diffrence];
                int SecondIndex = i;
                int[] index = new int[] {FirstIndex,SecondIndex};
                return index;
            }
            else if(!map.ContainsKey(diffrence))
            {
                map[arr[i]] = i;
            }
        } 
        int[] NotFound = {-1, -1};
        return NotFound;
    }
}



class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of element: ");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Elements: ");
        string? line = Console.ReadLine();
        if(line == null)
        {
            Console.WriteLine("Invalid Input");
            return;
        }
        string[] input = line.Split(' ');

        int[] arr = new int[n];
        for(int i=0; i<n; i++)
        {
            arr[i] = Convert.ToInt32(input[i]); 
        }
        Console.WriteLine("Enter the Target: ");
        int target = Convert.ToInt32(Console.ReadLine());

        Console.Write("Output: ");
        int[] result = Soluation.TwoSum(arr, target);
        foreach(int i in result)
        {
            Console.Write($" {i},");
        }
    }
}