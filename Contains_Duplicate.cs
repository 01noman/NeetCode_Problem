using System;
using System.Collections.Generic;

public class Solution
{
    public static bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach(int num in nums)
        {
            if(seen.Contains(num))
            {
                return true;
            }
            else
            {
                seen.Add(num);
            }
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter The number of elemrnt: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] nums = new int[n];
        for(int i=0; i<n; i++)
        {
            nums[i] = Convert.ToInt32(input[i]);
        }
        //Solution sol = new Solution();
        Console.WriteLine($"Output: {Solution.ContainsDuplicate(nums)}");
    }
}





// using System;
// using System.Collections.Generic;

// public class Solution
// {
//     public bool ContainsDuplicate(int[] nums)
//     {
//         HashSet<int> seen = new HashSet<int>();

//         foreach(int num in nums)
//         {
//             if(seen.Contains(num))
//             {
//                 return true;
//             }
//             else
//             {
//                 seen.Add(num);
//             }
//         }
//         return false;
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the number of elements: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         string[] input = Console.ReadLine().Split(' ');
//         int[] nums = new int[n];
//         for(int i=0; i<n; i++)
//         {
//             nums[i] = Convert.ToInt32(input[i]);
//         }

//         Solution sol = new Solution();
//         Console.WriteLine($"Output: {sol.ContainsDuplicate(nums)}");
//     }
// }
