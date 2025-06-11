public class Solution {
    public int MaxDifference(string s) {
        int menor=100, maior=0, count=0;
        for(int i=0;i<s.Length;i++)
        {
            for(int j=0;j<s.Length;j++)
            {
                if(s[i] == s[j])
                {
                    count = count + 1;
                }
            }
            if(count > maior && count % 2 != 0)
                maior = count;

            else
                if(count < menor && count % 2 == 0)
                    menor = count;
            
            count = 0;
        }
        return maior - menor;
    }
}