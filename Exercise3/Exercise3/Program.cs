using System;

public class Solution
{
    public  int RomanToInt(string s)
    {
        Dictionary<char, int> romanVaules = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int total = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int current = romanVaules[s[i]];
            if (i + 1 < s.Length && current < romanVaules[s[i + 1]])
            {
                total -= current;
            }
            else
            {
                total += current;
            }
        }
        return total;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Solution solution = new Solution();
        Console.WriteLine("III is " + solution.RomanToInt("III"));
        Console.WriteLine("LVIII is " + solution.RomanToInt("LVIII"));
        Console.WriteLine("MCMXCIV is " + solution.RomanToInt("MCMXCIV"));
    }
}
