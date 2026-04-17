public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int left = 0;
        int right = numbers.Length-1;

        while(left < right)
        {
            int result = numbers[left] + numbers[right];
            if(result == target)
            {
                return new int [] { left+1 , right +1};
            }
            else if(result > target)
            {
                right--;
            }
            else if(result < target)
            {
                left++;
            }
        }
        return new int [] { 0 , 0 };
    }
}
