﻿using System;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { }; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        
        Solution solution = new Solution();
        int[] result = solution.TwoSum(nums, target);

        
        if (result.Length > 0)
        {
            Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}

