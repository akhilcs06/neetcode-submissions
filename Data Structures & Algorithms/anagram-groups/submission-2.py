class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        anagram_dict = defaultdict(list)
        for s in strs:
            count = [0] * 26
            print(f"Processing word: {s}")
            for c in s:
                diff = ord(c) - ord('a') 
                count[diff] += 1
            key = tuple(count)
            anagram_dict[key].append(s)

        return list(anagram_dict.values())