public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
   int eliminatedElement = 0;
 int[] answer = new int[nums.Length];
 for (int i = 0; i < nums.Length; i++)
 {
     eliminatedElement = nums[i];
     int product = 1;
     for (int j = 0; j < nums.Length; j++)
     {
         if (i != j)
         {
             product = product * nums[j];
         }
     }
     answer[i] = product;
 }
 return answer;
    }
}
