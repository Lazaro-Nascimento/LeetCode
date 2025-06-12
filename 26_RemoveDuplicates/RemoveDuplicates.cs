/*
https://leetcode.com/problems/remove-duplicates-from-sorted-array/solutions/6834246/beast-100-with-c-by-lazaro-nascimento-ezms/
Autor: Antônio Lázaro
*/

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int current = 999;
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (current != nums[i])
            {
                current = nums[i];

                nums[count] = current;
                count = count + 1;
            }
        }
        return count;
    }
}