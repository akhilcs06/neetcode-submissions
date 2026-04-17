public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int, List<int>> valuePairs = new Dictionary<int, List<int>>();
        int[] result = new int[k];
        foreach (int i in nums)
        {
            if(valuePairs.ContainsKey(i))
            {
                valuePairs[i].Add(i);
            }
            else
            {
                valuePairs[i] = new List<int> { i };
            }
        }
        int v = 1;
        var sortedList = valuePairs
          .OrderByDescending(kvp => kvp.Value.Count) // Order by count of elements in List<int> in descending order
          .ToList();

        foreach (var i in sortedList)
        {
            if(v <= k)
            {
                result[v-1]= i.Key;
                v++;


            }
             
            if(v-1 == k)
            {
                return result;
            }
        }
        return result;
    }
}
