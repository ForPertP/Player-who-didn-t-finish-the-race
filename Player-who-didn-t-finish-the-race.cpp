#include <string>
#include <vector>
#include <unordered_map>

using namespace std;

string solution(vector<string> participant, vector<string> completion)
{
    unordered_map<string, int> counts;
    counts.reserve(completion.size());

    for (const auto& name : completion) ++counts[name];

    for (const auto& name : participant)
    {
        auto it = counts.find(name);
        if (it == counts.end() || it->second == 0) return name;
        --it->second;
    }

    return "";
}


string solution(vector<string> participant, vector<string> completion)
{
    unordered_map<string, int> counts;
    counts.reserve(participant.size());

    for (const auto& name : participant) ++counts[name];
    for (const auto& name : completion) --counts[name];

    for (const auto& [name, count] : counts)
        if (count > 0) return name;

    return "";
}

