public class Solution {
    public int BitwiseComplement(int n) {
        int temp=n;
        int result=0;
        int weight=1;
        if(temp==0){
            return 1;
        }

        while(temp>0){
            int bit=temp%2;
            if(bit==0){
                result=result+(1*weight);
            }else{
                 result=result+(0*weight);
            }
            weight=weight*2;
            temp=temp/2;
        }
return result;
    }
}