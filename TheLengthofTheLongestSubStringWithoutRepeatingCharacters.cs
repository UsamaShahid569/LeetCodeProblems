#Given a string s, find the length of the longest substring without repeating characters.

namespace LeetCode
{
    public class Program
    {         
        public int LengthOfLongestSubstring(string s)
        {
            int retVal = 0;
            List<char> tempList = new();
            if (s.Length == 0) { return retVal; }
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = i; j < s.Length; j++)
                {
                    if (tempList.Any(x => x == s[j]))
                    {
                        if (tempList.Count > retVal)
                        {
                            retVal = tempList.Count;
                        }
                        tempList = new();
                        break;
                    }
                    else
                    {
                        tempList.Add(s[j]);
                    }
                }
            }

            return tempList.Count >  retVal ? tempList.Count : retVal;
        }
    }
}
