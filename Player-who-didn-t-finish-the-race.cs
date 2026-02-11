using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] participant, string[] completion) {
        Dictionary<string, int> counts = new Dictionary<string, int>(completion.Length);

        foreach (string name in completion) {
            if (counts.ContainsKey(name))
                counts[name]++;
            else
                counts[name] = 1;
        }

        foreach (string name in participant) {
            if (!counts.ContainsKey(name) || counts[name] == 0) {
                return name;
            }
            counts[name]--;
        }

        return "";
    }
}


public class Solution {
    public string solution(string[] participant, string[] completion) {
        Dictionary<string, int> counts = new Dictionary<string, int>(participant.Length);

        foreach (string name in participant) {
            if (counts.ContainsKey(name)) counts[name]++;
            else counts[name] = 1;
        }

        foreach (string name in completion) {
            if (counts.ContainsKey(name)) {
                counts[name]--;
            } else {
                counts[name] = -1;
            }
        }

        foreach (var pair in counts) {
            if (pair.Value > 0) {
                return pair.Key;
            }
        }

        return "";
    }
}
