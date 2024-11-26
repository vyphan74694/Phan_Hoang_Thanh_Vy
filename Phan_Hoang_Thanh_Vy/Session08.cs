namespace Phan_Hoang_Thanh_Vy
{
    internal class Session08
    {
    
    
    // 1. To input a string and print it
    public static void PrintString(string input)
    {
        Console.WriteLine("Input String: " + input);
    }

    // 2. To find the length of a string without using a library function
    public static int FindStringLength(string input)
    {
        int length = 0;
        foreach (char c in input)
        {
            length++;
        }
        return length;
    }

    // 3. To separate individual characters from a string
    public static void SeparateCharacters(string input)
    {
        foreach (char c in input)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
    }

    // 4. To print individual characters of the string in reverse order
    public static void PrintReverseCharacters(string input)
    {
        for (int i = input.Length - 1; i >= 0; i--)
        {
            Console.Write(input[i] + " ");
        }
        Console.WriteLine();
    }

    // 5. To count the total number of words in a string
    public static int CountWords(string input)
    {
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    // 6. To compare two strings without using string library functions
    public static bool CompareStrings(string str1, string str2)
    {
        if (str1.Length != str2.Length) return false;

        for (int i = 0; i < str1.Length; i++)
        {
            if (str1[i] != str2[i])
            {
                return false;
            }
        }
        return true;
    }

    // 7. To count the number of alphabets, digits and special characters in a string
    public static void CountCharacters(string input)
    {
        int alphabets = 0, digits = 0, specialChars = 0;
        foreach (char c in input)
        {
            if (Char.IsLetter(c))
                alphabets++;
            else if (Char.IsDigit(c))
                digits++;
            else
                specialChars++;
        }
        Console.WriteLine($"Alphabets: {alphabets}, Digits: {digits}, Special Characters: {specialChars}");
    }

    // 8. To count the number of vowels or consonants in a string
    public static void CountVowelsAndConsonants(string input)
    {
        int vowels = 0, consonants = 0;
        string lowerInput = input.ToLower();
        
        foreach (char c in lowerInput)
        {
            if (Char.IsLetter(c))
            {
                if ("aeiou".Contains(c))
                    vowels++;
                else
                    consonants++;
            }
        }
        Console.WriteLine($"Vowels: {vowels}, Consonants: {consonants}");
    }

    // 9. To check whether a given substring is present in the given string
    public static bool IsSubstringPresent(string input, string substring)
    {
        for (int i = 0; i <= input.Length - substring.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < substring.Length; j++)
            {
                if (input[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
                return true;
        }
        return false;
    }

    // 10. To search for the position of a substring within a string
    public static int FindSubstringPosition(string input, string substring)
    {
        for (int i = 0; i <= input.Length - substring.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < substring.Length; j++)
            {
                if (input[i + j] != substring[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
                return i;
        }
        return -1; // substring not found
    }

    // 11. To check whether a character is an alphabet and not and if so, check for the case
    public static void CheckCharacter(char c)
    {
        if (Char.IsLetter(c))
        {
            if (Char.IsUpper(c))
                Console.WriteLine($"{c} is an uppercase alphabet.");
            else
                Console.WriteLine($"{c} is a lowercase alphabet.");
        }
        else
        {
            Console.WriteLine($"{c} is not an alphabet.");
        }
    }

    // 12. To find the number of times a substring appears in a given string
    public static int CountSubstringOccurrences(string input, string substring)
    {
        int count = 0;
        int index = 0;
        while ((index = input.IndexOf(substring, index)) != -1)
        {
            count++;
            index += substring.Length;
        }
        return count;
    }

    // 13. To insert a substring before the first occurrence of a string
    public static string InsertSubstringBeforeFirstOccurrence(string input, string insert, string target)
    {
        int index = input.IndexOf(target);
        if (index != -1)
        {
            return input.Substring(0, index) + insert + input.Substring(index);
        }
        return input; // If target not found, return input as is
    }
    }
}
