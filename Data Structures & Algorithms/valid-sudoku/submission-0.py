class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        seen = set()
        for r in range(9):
            for c in range(9):
                val = board[r][c]
                if val == ".":
                    continue

                if ("r",r,val) in seen or \
                   ("c",c,val) in seen or \
                   ("b",r//3,c//3,val) in seen:
                        return False
                seen.add(("r",r,val))
                seen.add(("c",c,val))
                seen.add(("b",r//3,c//3,val))
        return True