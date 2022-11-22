class Program
{
    static void Main()
    {
         int number = int.Parse(Console.ReadLine());
       
        
        Romance romance = new();
        string result = romance.IntToRoman(number);
        Console.WriteLine(result);

    }
}
public class Romance
{
    public string IntToRoman(int num)
    {
        string romanResult = string.Empty;
        string[] romanLetters =
        {
            "M",
            "CM",
            "D",
            "CD",
            "C",
            "XC",
            "L",
            "XL",
            "X",
            "IX",
            "V",
            "IV",
            "I"
        };
        int[] number =
        {
           1000,
           900,
           500,
           400,
           100,
           90,
           50,
           40,
           10,
           9,
           5,
           4,
           1

        };
        int i = 0;
        while (num != 0)
        {
            if (num >= number[i])
            {
                num -= number[i];
                romanResult += romanLetters[i];
            }
            else
            {
                i++;
            }
        }

        return romanResult;

    }
}