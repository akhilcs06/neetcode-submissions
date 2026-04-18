class Solution:
    def search(self, nums: List[int], target: int) -> int:
        l = 0
        r = len(nums)-1
        result = -1
        middle = r//2
        while(l <= r):
            middle = (l + r) //2
            if(nums[middle] == target):
                result = middle
                break
            if(nums[middle] > target):
                r = middle - 1
            if(nums[middle] < target): 
                l = middle + 1
        return result