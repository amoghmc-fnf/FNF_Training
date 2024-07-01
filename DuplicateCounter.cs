using System;
using System.Collections.Generic;

public static class DuplicateCounter {
    private const string unique = "unique";
    private const string duplicate = "duplicate";

    public static Dictionary<string, List<string>> GetDuplicateAndUnique(string message) {
        Dictionary<string, int> dupCountDict = new Dictionary<string, int>();
        message = message.ToLower();
        var curr = "";

        foreach (var item in message) {
            if (item.Equals(' ') || item.Equals(',')) {
                if (curr.Equals("")) {
                    continue;
                }
                else if (dupCountDict.ContainsKey(curr)) {
                    dupCountDict[curr] += 1;
                    // Console.WriteLine("{0} {1}", curr, dupCountDict[curr]);
                }
                else {
                    dupCountDict[curr] = 1;
                    // Console.WriteLine("{0} {1}", curr, dupCountDict[curr]);
                }
                curr = "";
            }
            else {
                curr += item;
            }
        }

        if (!curr.Equals("")) {
            if (dupCountDict.ContainsKey(curr)) {
                dupCountDict[curr] += 1;
            }
            else {
                dupCountDict[curr] = 1;
            }
        }

        List<string> duplicateList = new List<string>();
        List<string> uniqueList = new List<string>();
        foreach (var item in dupCountDict) {
            if (dupCountDict[item.Key] > 1) {
                duplicateList.Add(item.Key);
                // Console.WriteLine("{0} {1} {2}", item.Key, dupCountDict[item.Key], "Dup");
            }
            else {
                uniqueList.Add(item.Key);
                // Console.WriteLine("{0} {1} {2}", item.Key, dupCountDict[item.Key], "Uniq");
            }
        }
        Dictionary<string, List<string>> resultDict = new Dictionary<string, List<string>>();
        resultDict[unique] = uniqueList;
        resultDict[duplicate] = duplicateList;
        return resultDict;
    }
}