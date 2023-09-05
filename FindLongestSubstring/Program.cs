static int LengthOfLongestSubstring(string s)
{
    HashSet<char> chars = new HashSet<char>();
    int left = 0;
    int right = 0;
    int max = 0;
    while (right < s.Length)
    {
        if (!chars.Contains(s[right]))
        {
            chars.Add(s[right]);
            right++;
            max = Math.Max(max, chars.Count);
        }
        else
        {
            chars.Remove(s[left]);
            left++;
        }
    }
    return max;
}

String s = "hejmeddigjeghedderkaj";
Console.WriteLine(LengthOfLongestSubstring(s));