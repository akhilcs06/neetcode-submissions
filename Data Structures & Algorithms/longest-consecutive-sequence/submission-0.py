class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        hash_items = set(nums)
        count = 0

        for num in nums:
            i=0
            if num-1 in  hash_items:
                continue
            while((num+i) in hash_items):
                i += 1   
            count = max(count,i)
            
        return count