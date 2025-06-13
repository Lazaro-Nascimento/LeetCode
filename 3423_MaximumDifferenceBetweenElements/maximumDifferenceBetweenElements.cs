/*
https://leetcode.com/problems/maximum-difference-between-adjacent-elements-in-a-circular-array/solutions/6837997/solucao-c-100-solution-c-beast-100-by-la-b21t/
Autor: Antônio Lázaro
GitHub: Lazaro-Nascimento
*/
public class Solution
{
    public int MaxAdjacentDistance(int[] nums)
    {
        int maior = Math.Max(nums[0], nums[nums.Length - 1]) - Math.Min(nums[0], nums[nums.Length - 1]);
        int diff = 0;
        int i = 0, j = 1;

        while (j != nums.Length)
        {
            diff = Math.Max(nums[i], nums[j]) - Math.Min(nums[i], nums[j]);

            if (diff > maior)
                maior = diff;

            i++;
            j++;
        }
        return maior;
    }
}