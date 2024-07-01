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
                Console.WriteLine("{0} {1}", item, charToInt[item]);
            }
        }
    }

    public string GetEncodedMessage(string message) {
        string encoded = "";
        if (message == (null)) {
            throw new NullReferenceException();
        }
        if (message.Equals("")) {
            throw new ArgumentException();
        }
        foreach (var item in message) {
            if (item.Equals(' ')) {
                encoded += "-";
                continue;
            }
            if (!encoded.Equals("")) {
                encoded += ",";
            }
            encoded += charToInt[item];
        }
        return encoded;
    }

    static void Main() {
        string msg = "The quick and brown fox jumps over the Lazy Dog";
        StringEncoder strEncoder = new StringEncoder(msg);
        try {
            Console.WriteLine(strEncoder.GetEncodedMessage("bangalore"));
            Console.WriteLine(strEncoder.GetEncodedMessage(null));
            Console.WriteLine(strEncoder.GetEncodedMessage(""));
        }
        catch (NullReferenceException ex) {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex) {
            Console.WriteLine(ex.Message);
        }
    }
}