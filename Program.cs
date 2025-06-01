public class Program
{
    public static void Main()
    {
        System.Console.WriteLine(MaxArea([1,8,6,2,5,4,8,3,7]));
    }
    public static int MaxArea(int[] height) {
        int maior = 0;
        for(int i=0; i<height.Length; i++)
        {
            for(int j=i+1;j<height.Length;j++)
            {
                if(height[i] > height[j])
                {
                    if(maior < height[i] * (j - i))
                    {
                        maior = (j - i) * height[j];
                    }
                }
                else
                {
                    if(maior < height[i] * (j - i))
                    {
                        maior = (j - i) * height[i];
                    }
                }
            }
        }
        return maior;
    }
}