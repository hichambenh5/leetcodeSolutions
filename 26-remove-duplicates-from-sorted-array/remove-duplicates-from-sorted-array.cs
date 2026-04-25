public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length==0)return 0;
       HashSet<int> res=new HashSet<int>(nums);
       int index=0;
       foreach(int num in res){
        nums[index]=num;
        index++;
       }
       return res.Count;
    }
}