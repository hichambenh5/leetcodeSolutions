public class Solution {
    public int[][] LargestLocal(int[][] grid) {
        int n=grid.Length;
        int [][]result=new int[n-2][];
        for(int i=0;i<n-2;i++){
            result[i]=new int[n-2];
        }
        for(int i=0;i<=n-3;i++){
            for(int j=0;j<=n-3;j++){
                int max = int.MinValue;
                for(int x=i;x<i+3;x++){
                    for(int y=j;y<j+3;y++){
                        max=Math.Max(max,grid[x][y]);
                    }
                }
                result[i][j]=max;
            }
        }
return result;
    }
}