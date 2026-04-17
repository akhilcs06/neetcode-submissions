public class Solution {
    public bool IsAnagram(string s, string t) {
if(s.Length != t.Length)
        {
            return false;
        }
        var letters = new Dictionary<char,int>();
        foreach(char letter in s)
        {
            if(letters.ContainsKey(letter))
            {
               letters[letter]++;
            }
            else
            {
                letters[letter] = 1;
            }
        }
        foreach(char letter in t)
        {
            if(letters.ContainsKey(letter))
            {
                letters[letter]--;
                 if(letters[letter] <0)
                {
                    return false;
                }
            }
            else 
            {
                return false;
            }
          
        }
        return true;
    }
}
