using System;
ReverseWords("Jack");
string ReverseWords(string s)
{
    Console.WriteLine(s);
    char[] reverseChar = s.ToCharArray();
    char[] backwardsWord = reverseChar;
    int lengthWord = s.Length - 1;
    for (int i = 0; i < s.Length; i++)
    {
        Console.WriteLine(i);
        Console.WriteLine(s.Length);
        Console.WriteLine(reverseChar[(lengthWord) - i]);
        backwardsWord[i] = reverseChar[(s.Length - 1) - i];

    }
    Console.WriteLine(backwardsWord);
    string wordTwoString = new string(backwardsWord);

    Console.WriteLine(wordTwoString);
    return "outer Done";

}
