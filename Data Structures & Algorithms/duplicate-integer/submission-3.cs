public class Solution {
    public bool hasDuplicate(int[] nums) {
    HashSet<int> numbers = new HashSet<int>();
        for(int i= 0; i < nums.Length;i++)
            numbers.Add(nums[i]);

    if (numbers.Count == nums.Length)
        return false;
    else
        return true;
    }
}
