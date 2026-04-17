public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> keyValuePairs = new Dictionary<string,List<string>>();

foreach (string s in strs)
{
    int[] store = new int[26];

    foreach (int c in s)
    {
        int j = c - 'a';
        store[j] = store[j]+1;
    }
    var key = string.Join(",", store);

    if(!keyValuePairs.ContainsKey(key))
    {
        keyValuePairs[key] = new List<string>();
    }
    keyValuePairs[key].Add(s);
}
return new List<List<string>>(keyValuePairs.Values);
    }
}
