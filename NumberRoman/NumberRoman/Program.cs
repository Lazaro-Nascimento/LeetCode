public class Program
{
    public static void Main()
    {
        int[]? v = TwoSum([2,8,4], 6);
        
        if(v != null)
            System.Console.WriteLine($"{v[0]} {v[1]}");
    }
    public static int[]? TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        return null;
    }
}