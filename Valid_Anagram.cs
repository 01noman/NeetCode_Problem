using System;
using System.Collections.Generic;

public class Solution
{
    public static bool Valid_Anagram(string s, string t)
    {
        if(s.Length !=  t.Length)
        {
            return false;
        }

        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach(char c in s)
        {
            if(count.ContainsKey(c))
            {
                count[c]++;
            }
             else
            {
                count[c] = 1;
            }
        }
        
        foreach(char c in t)
        {
            if(!count.ContainsKey(c))
            {
                return false;
            }
            else
            {
                count[c]--;
            }

            if(count[c] == 0)
            {
                count.Remove(c);
            }
        }

        return count.Count == 0;
   
    }
}







class Program
{
    public static void Main()
    {
        string s = Console.ReadLine();
        string t = Console.ReadLine();

        Console.WriteLine($"Output: {Solution.Valid_Anagram(s,t)}");
    }
}