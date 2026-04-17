class Solution:
    def getConcatenation(self, nums: List[int]) -> List[int]:
        lengthOfNums = len(nums)   
        size = 2 * lengthOfNums  
        ans = [0] * size
        i=0
        for i in range(size):
            if i < lengthOfNums:
                ans[i]=nums[i]
            else:
                ans[i] = nums[i-lengthOfNums]
        return ans