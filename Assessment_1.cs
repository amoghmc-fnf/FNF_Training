using System;

class Test {
    static void Main() {
        // 1st question
        // StringEncoderUnitTests();
        // StringEncoderUserTest();

        // 2nd question
        var myDict = DuplicateCounter.GetDuplicateAndUnique("do not call me, let me call you");
        
        foreach(var item in myDict["unique"]) {
            Console.WriteLine("{0}: {1}", item, "Unique");
        }

        foreach(var item in myDict["duplicate"]) {
            Console.WriteLine("{0}: {1}", item, "Duplicate");
        }
    }

    static void StringEncoderUserTest() {
        string msg = "The quick and brown fox jumps over the Lazy Dog";
        StringEncoder strEncoder = new StringEncoder(msg);
        
        while (true) {
            try {
                String userInput = MyConsole.GetString("Enter a string to encode:");
                Console.WriteLine(strEncoder.GetEncodedMessage(userInput));
            }
            catch (NullReferenceException ex) {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }

    static void StringEncoderUnitTests() {
        string msg = "The quick and brown fox jumps over the Lazy Dog";
        StringEncoder strEncoder = new StringEncoder(msg);

        // null test
        try {
            Console.WriteLine(strEncoder.GetEncodedMessage(null));
        }
        catch (NullReferenceException ex) {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex) {
            Console.WriteLine(ex.Message);
        }

        // empty string test
        try {
            Console.WriteLine(strEncoder.GetEncodedMessage(""));
        }
        catch (NullReferenceException ex) {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex) {
            Console.WriteLine(ex.Message);
        }

        // additional tests
        Console.WriteLine(strEncoder.GetEncodedMessage("bangalore"));
        Console.WriteLine(strEncoder.GetEncodedMessage("Global Village"));
        Console.WriteLine(strEncoder.GetEncodedMessage("TTG"));
        Console.WriteLine(strEncoder.GetEncodedMessage("mindtree"));
        Console.WriteLine(strEncoder.GetEncodedMessage("West Campus"));
        // starting with space
        Console.WriteLine(strEncoder.GetEncodedMessage(" bangalore"));
        // ending with space
        Console.WriteLine(strEncoder.GetEncodedMessage("bangalore "));
        // empty with space
        Console.WriteLine(strEncoder.GetEncodedMessage("  "));
    }
}