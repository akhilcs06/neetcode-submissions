public class Solution {

    public string Encode(IList<string> strs) {
          return string.Concat(strs.Select(s =>$"{ s.Length}#{s}"));
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
         var i = 0;
        while(i < s.Length)
        {
            var j = i;
            while(s[j] != '#')
            {
                ++j;
            }
            int.TryParse(s.Substring(i,j-i),out var length);
            j++;
            result.Add(s.Substring(j,length));
            i=j+length;
        }
        return result;
   }
}
