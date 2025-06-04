/*
https://leetcode.com/problems/palindrome-number/description/
Author: "Antônio Lázaro"
Git-Hub: "Lazaro-Nascimento"
*/
public class Solution
{

    public bool IsPalindrome(int x)
    {

        string number = Convert.ToString(x);
        int j = number.Length - 1, i = 0;
        if (x < 0)
            return false;
        else
            if (x >= 0 && x < 10)
            return true;

        do
        {

            if (number[i] != number[j])
                return false;

            i++;
            j--;

        } while (i < number.Length && j >= 0);
        return true;
    }
}