/*
https://leetcode.com/problems/longest-common-prefix/
Autor: Antônio Lázaro
*/
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string commonPrefix = "";
        string smallString;
        int size = strs[0].Length, index = 0;

        for (int i = 0; i < strs.Length; i++)
        {
            if (strs[i].Length < size)
            {
                size = strs[i].Length;
                index = i;
            }
        }
        smallString = strs[index];

        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < strs.Length; i++)
            {
                if (smallString[j] != strs[i][j])
                    return commonPrefix;
                else
                    if (i == strs.Length - 1)
                    commonPrefix += strs[i][j];
            }
        }
        return commonPrefix;
    }
}