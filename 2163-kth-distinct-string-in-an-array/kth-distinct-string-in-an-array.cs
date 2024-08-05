public class Solution {
    public string KthDistinct(string[] arr, int k) {
         Dictionary<string, int> map = new Dictionary<string, int>();
        List<string> order = new List<string>();
        foreach (string s in arr) {
            if (map.ContainsKey(s)) {
                ++map[s];
            } else {
                map.Add(s, 1);
                order.Add(s);
            }
        }
        foreach (string s in order) {
            if (map[s] == 1) {
                --k;
                if (k == 0) {
                    return s;
                }
            }
        }
        return "";
    }
}