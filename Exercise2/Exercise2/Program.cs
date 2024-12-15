using System;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        int number = x;
        int palindrome = 0;
        while (x > 0)
        {
            palindrome = palindrome * 10 + x % 10;
            x /= 10;
        }
        if (palindrome == number)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {

        Solution solution = new Solution();
        Console.WriteLine(solution.IsPalindrome(121));
    }
}