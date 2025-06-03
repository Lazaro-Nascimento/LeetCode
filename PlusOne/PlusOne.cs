public class Solution {
    public int[] PlusOne(int[] digits)
    {
        int novoTamanho = digits.Length;
        int cont = 0;
        for(int i=0;i<digits.Length;i++)
        {
            if(digits[i] == 9)
                cont=cont+1;
        }
        if(cont == digits.Length){
            novoTamanho++;
            int[] newdigits = new int[novoTamanho];
            for(int i=newdigits.Length-1;i>0;i--)
            {
                newdigits[i] = 0;
            }
            newdigits[0] = 1;
            return newdigits;
        }

        for(int i=digits.Length-1;i>=0;i--){
            if(digits[i] + 1 == 10){
                digits[i] = 0;
            }
            else{
                digits[i] += 1;
                break;
            }
        }
        return digits;
    }
}