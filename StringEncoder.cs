using System;
using System.Collections.Generic;

public class StringEncoder {
    private Dictionary<char, string> charToInt = new Dictionary<char, string>();

    public StringEncoder(string message) {
        message = message.ToLower();
        int wordCount = 0;
        int letterCount = -1;

        foreach (var item in message) {
            if (item.Equals(' ')) {
                wordCount += 1;
                letterCount = -1;
            }
            else {
                letterCount += 1;
            }

            if (!charToInt.ContainsKey(item) && !item.Equals(' '))
            {
                charToInt[item] = string.Format("{0}{1}", wordCount, letterCount);
            }
        }
    }

    public string GetEncodedMessage(string message) {
        string encoded = "";
        var check = 0;
        message = message.ToLower();
        if (message == (null)) {
            throw new NullReferenceException();
        }
        if (message.Equals("")) {
            throw new ArgumentException();
        }
        foreach (var item in message) {
            if (item.Equals(' ')) {
                encoded += "-";
                check = 1;
                continue;
            }
            if (!encoded.Equals("") && check == 0) {
                encoded += ",";
            }
            check = 0;
            encoded += charToInt[item];
        }
        return encoded;
    }
}