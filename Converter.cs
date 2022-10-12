class Converter
{
    public enum BaseNumber
    {
        Binary = 2,
        Octal = 8,
        Hexadecimal = 16
    }
    public static int ConvertFrom(string input, BaseNumber baseNumber)
    {
        int result = 0, weight = 0;
        input.ToCharArray();
        if ((int)baseNumber is 16)
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int hexaCharValue = (int)char.Parse(input[i].ToString().ToUpper()) - 55;
                result += hexaCharValue * (int)(Math.Pow((int)baseNumber, weight));
                weight++;
            }
        }
        else
        {
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += int.Parse(input[i].ToString()) * (int)(Math.Pow((int)baseNumber, weight));
                weight++;
            }
        }
        return result;
    }

    public static string ConvertTo(int input, BaseNumber baseNumber)
    {
        int reminder = 0;
        string result = "";

        while (input is not 0)
        {
            reminder = input % (int)baseNumber;
            result += reminder.ToString();
            input /= (int)baseNumber;
        }
        return Reverse(result);
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}