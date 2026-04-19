import math
class Solution:
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        left = 1

        right = max(piles)
        result = 0
        while left < right:
            middle = (left + right)//2
        
            ceil_sum = 0
            for num in piles:
                ceil_sum = ceil_sum + math.ceil(num/middle)
                
            if ceil_sum <= h:
                right = middle
            else:
                left = middle+1

        return left
    
        
    
    

        
