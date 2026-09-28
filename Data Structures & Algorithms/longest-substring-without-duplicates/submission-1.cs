public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int right = 0;
        int maxL = 0;

        HashSet<Char> ss = new HashSet<Char>();

        foreach (char c in s)
        {
            while (ss.Contains(c)) {
                ss.Remove(s[left]);
                left++;
            }
            ss.Add(c);
            maxL = Math.Max(maxL, right - left + 1);

            right++;
        }
        return maxL;
    }
}
