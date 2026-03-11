public class Solution {
    public int SingleNumber(int[] nums) {
        int result=0;
        for(int i=0;i<=nums.Length-1;i++){
            result=result^nums[i];
        }
         return result;
    }
   
}