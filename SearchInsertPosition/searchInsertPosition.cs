/*
https://leetcode.com/problems/search-insert-position/solutions/6827397/search-insert-position-beast

Autor: Antônio Lázaro
GitHub: Lazaro-Nascimento
*/

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int index = 0;
        for(int i=0;i<nums.Length;i++)
        {
            if(target > nums[i])
                index++;
        }
        return index;
    }
}