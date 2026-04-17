public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] ans= new int[2*nums.Length];
        for(int i = 0; i <= ans.Length-1; i++)
        {
           
            ans[i] = nums[i % nums.Length];
           
        }
        return ans;
    }
}