using System;
using System.Collections.Generic;

namespace LongestSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = LengthOfLongestSubstring("pwwkew");
        }
        private static int LengthOfLongestSubstring(string s)
        {
            try
            {
                int n = s.Length;
                int res = 0;
                int i = 0; // left pointer of the sliding window
                Dictionary<char,int> visited = new Dictionary<char, int>(); // to keep track of visited characters and their indices

                for (int j = 0; j < n; j++) // right pointer of the sliding window
                {
                    char c = s[j];
                    if (visited.ContainsKey(c)) // if the character is already in the visited map
                    {
                        // update the left pointer to the next position of the repeating character
                        // max() is used to make sure the left pointer never moves backward
                        i = Math.Max(i, visited[c] + 1);
                    }
                    // update the visited map with the current character and its index
                    visited[c] = j;
                    // update the length of the longest substring seen so far
                    res = Math.Max(res, j - i + 1);
                }
                return res;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}