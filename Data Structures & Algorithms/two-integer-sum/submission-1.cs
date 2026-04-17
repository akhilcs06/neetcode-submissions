public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
       Dictionary<int,int> map = new Dictionary<int,int>();

     for (int i = 0; i < nums.Length; i++)
     {
       var difference = target - nums[i] ;
         if (map.ContainsKey(difference))
         {
             return new int[] { map[difference], i };
         }
         map[nums[i]]=i;
     }
         return null;

    }
}
