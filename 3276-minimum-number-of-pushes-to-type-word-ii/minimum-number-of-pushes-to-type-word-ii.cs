public class Solution {
    public int MinimumPushes(string word) {
        var freq = new Dictionary<char, int>();
        foreach (char c in word) {
            if (freq.ContainsKey(c)) {
                freq[c]++;
            } else {
                freq[c] = 1;
            }
        }
        var sortedFreq = freq.Values.ToList();
        sortedFreq.Sort((a, b) => b - a);
        int result = 0;
        int i = 0;
        foreach (int n in sortedFreq) {
            result += n * (i / 8 + 1);
            i++;
        }
        return result;
    }
}