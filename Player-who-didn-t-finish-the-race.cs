using System;
using System.Collections.Generic;

public class Solution 
{
    public string solution(string[] participant, string[] completion) 
    {
        var counts = new Dictionary<string, int>(completion.Length);

        foreach (var name in completion) 
        {
            if (counts.ContainsKey(name)) counts[name]++;
            else counts[name] = 1;
        }

        foreach (var name in participant) 
        {
            if (!counts.ContainsKey(name) || counts[name] == 0) 
            {
                return name;
            }
            counts[name]--;
        }

        return "";
    }
}


public class Solution 
{
    public string solution(string[] participant, string[] completion) 
    {
        var counts = new Dictionary<string, int>(participant.Length);

        foreach (var name in participant) 
        {
            if (counts.ContainsKey(name)) counts[name]++;
            else counts[name] = 1;
        }

        foreach (var name in completion) 
        {
            if (counts.ContainsKey(name)) counts[name]--;
            else counts[name] = -1;
        }

        foreach (var pair in counts) 
        {
            if (pair.Value > 0) return pair.Key;
        }

        return "";
    }
}
