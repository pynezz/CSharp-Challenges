namespace Solution
{
    class Kata
    {
        public static bool IsValidIP(string input)
        {
            return input.Split('.').Length == 4 && input.Split('.').All(part => byte.TryParse(part, out var value) && value.ToString() == part && value >= 0 && value <= 255);
        }
    }
}
