public class Solution {
    public string Multiply(string num1, string num2) {
       int[] result = new int[num1.Length+num2.Length];
      for(int i=num1.Length-1;i>=0;i--){
         int carry=0;
        for(int j=num2.Length-1;j>=0;j--){
            int prodect=(num1[i]-'0')*(num2[j]-'0')+carry+result[i+j+1];
            result[i+j+1]=prodect%10;
            carry=prodect/10;

        }
         result[i]+=carry;
      }
       
int start=0;
    while(start<result.Length && result[start]==0){
        start++;
        if(start==result.Length)
           return "0";


    }
    StringBuilder sb = new StringBuilder();
for (int i = start; i < result.Length; i++)
{
    sb.Append(result[i]);

}
return sb.ToString();
    }
    }
  
    
      
