/*
https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/
Autor: Antônio Lázaro
*/
public class Solution
{
    public int StrStr(string haystack, string needle)
    {

        if (needle.Length > haystack.Length)
            return -1;

        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (i + j == haystack.Length)
                        return -1;

                    if (haystack[i + j] != needle[j])
                        break;

                    if (j == needle.Length - 1)
                        return i;
                }
            }
        }
        return -1;
    }
}