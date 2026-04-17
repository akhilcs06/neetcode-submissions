public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
    Dictionary<int, int> count = new Dictionary<int, int>();
    List<int>[] freq = new List<int>[nums.Length + 1];

    for (int i = 0; i < freq.Length; i++)
    {
        freq[i] = new List<int>();
    }

    int maxFrequency = 0;

    foreach (int n in nums)
    {
        if (count.ContainsKey(n))
        {
            count[n]++;
        }
        else
        {
            count[n] = 1;
        }
        maxFrequency = Math.Max(maxFrequency, count[n]);
    }

    foreach (var entry in count)
    {
        freq[entry.Value].Add(entry.Key);
    }

    int[] res = new int[k];
    int index = 0;
    for (int i = maxFrequency; i > 0 && index < k; i--)
    {
        foreach (int n in freq[i])
        {
            res[index++] = n;
            if (index == k)
            {
                return res;
            }
        }
    }
    return res;
}
}
