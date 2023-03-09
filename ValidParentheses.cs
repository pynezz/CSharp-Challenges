public class Parentheses
{
    public static bool ValidParentheses(string input)
    {
        // ASCII for '(' is 40 and for ')' is 41
        byte[] asciiBytes = System.Text.Encoding.ASCII.GetBytes(input);
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            // print

            System.Console.WriteLine(asciiBytes[i]);
            if (asciiBytes[i] == 40)
                count++;
            else if (asciiBytes[i] == 41)
                count--;

            if (count < 0) break;
        }
        return count == 0;
    }
}
