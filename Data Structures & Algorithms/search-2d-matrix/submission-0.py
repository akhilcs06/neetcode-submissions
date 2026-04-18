class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        top = 0
        bottom = len(matrix)-1
        result = False
        while top <= bottom:
            middle_row = (top + bottom)//2
            
            if target < matrix[middle_row][0]:
                bottom = middle_row - 1
            elif target > matrix[middle_row][-1]:
                top = middle_row + 1
            else:
                left  = 0
                right = len(matrix[middle_row])-1
                while left <= right:
                    middle_column = (left + right)//2
                    if target ==  matrix[middle_row][middle_column]:
                        print("if")
                        result = True
                        break
                    elif target < matrix[middle_row][middle_column]:
                        right = middle_column - 1
                        
                    else:
                        left = middle_column + 1
                break
        return result