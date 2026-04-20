class Solution:
    def search(self, nums: List[int], target: int) -> int:
        
        left = 0
        
        right = len(nums)-1
        
        result = -1
        while left <= right:
            middle = (left + right)//2
            if nums[middle]==target :
                result = middle
                break
        #if middle is less than right then right side is sorted
            if nums[middle] < nums[right]:
                if nums[middle] <= target and target <= nums[right]:
                    left = middle + 1
                else:
                    right= middle - 1
            #if middle is greater than left then left side is sorted
            elif nums[middle] >= nums[left]:
                if nums[middle] >= target and target >= nums[left]:
                    right = middle - 1
                else:
                    left = middle + 1
            
        return result