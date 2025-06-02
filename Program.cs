public class Solution {
    public int MaxArea(int[] height) {
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