public class Solution {
    public int MaxArea(int[] height) {
        int max=0;
        int left=0;
        int right=height.Length-1;
        int minHeight=0;
        int distance=0;
        int currentArea=0;
        while(left<right){
            if(height[left]>height[right]){
                minHeight=height[right];
            }else{
                 minHeight=height[left];
            }
            distance=right-left;
            currentArea=minHeight*distance;
           max= Math.Max(max, currentArea);
           if(height[left]>height[right]){
            right--;
           }else{
            left++;
           }

        }
        return max;
    }
}