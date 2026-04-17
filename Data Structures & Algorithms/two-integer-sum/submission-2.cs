public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dictionaryMap = new Dictionary<int,int>();
        var result = new int[2];
        for(int i = 0; i < nums.Length; i++)
        {
            int value = target - nums[i];
            if(dictionaryMap.ContainsKey(value))
            {
                result[0] = dictionaryMap[value];
                result[1] = i;
                return result;
            }
            else
            {
                  dictionaryMap[nums[i]] = i;
            }
        }
        return result;

    }
}
