/*
https://leetcode.com/problems/roman-to-integer/
Autor: Antônio Lázaro Nascimento Gomes
*/

public class Solution {
    public int RomanToInt(string s) {
        int romanInt = 0;
        int lastvalue = 0;
        Dictionary<char, int> roman = new Dictionary<char, int>{
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000
        };

        for(int i=0;i<s.Length;i++)
        {
            if(lastvalue < roman[s[i]] && lastvalue != 0)
                romanInt = romanInt + (roman[s[i]] - lastvalue);
            else
                if(i <  s.Length - 1 && roman[s[i]] >= roman[s[i+1]])
                    romanInt += roman[s[i]];
            else
                if(i == s.Length - 1 && lastvalue >= roman[s[i]] || s.Length == 1)
                    romanInt += roman[s[i]];
            lastvalue = roman[s[i]];
        }
        return romanInt;
    }
}