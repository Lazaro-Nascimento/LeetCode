public class Solution {

    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[nums.Length];
        int[] output = new int[2];
        int count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if((target - nums[i] > 0
             && (target - nums[i]) + nums[i] == target)
             || (target == 0))
            {
                result[count] = i;
                count = count + 1;
            }
            else 
                if((target - nums[i] <= 0
                 && (target - nums[i]) + nums[i] == target))
                {
                    result[count] = i;
                    count = count + 1;
                }
        }

        for(int i = 0;i<=count;i++)
        {
            for(int j = i + 1;j<count;j++)
            {
                if(nums[result[i]] + nums[result[j]] == target)
                {
                    output[0] = result[i];
                    output[1] = result[j];
                    return output;
                }
            }
        }
        return output; //apenas para validar "Retorno em todos os campos"
    }
}