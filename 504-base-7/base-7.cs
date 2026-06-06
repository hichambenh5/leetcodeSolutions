public class Solution {
    public string ConvertToBase7(int num) {
        if(num==0)return "0";
        bool isNegative=num<0;
        num=Math.Abs(num);
          Stack<int> stack = new Stack<int>();
          while(num>0){
             stack.Push(num%7);
             num=num/7;
          }
          string result= string.Join("",stack);
          return isNegative?"-"+result:result;
    }
}