using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_34
    {
    class Program
    {
    static void Main(string[] args)
    {
        BinaryToDecimal();
        DecimalToBinary();
        DecimalToOctal();
        DecimalToHex();
    }
    //BinaryToDecimal
    public static void BinaryToDecimal()
    {
        Console.WriteLine("Enter binary number to be converted into decimal");
        String bin = Console.ReadLine();
        int binary = Int16.Parse(bin);
        int i = 0, sum = 0;
        while (binary > 0)
        {
            int temp = binary;
            temp = temp % 10;
            double a = Math.Pow(2, i);
            i++;
            sum = sum + (int)(temp * a);
            binary = binary / 10;
        }
        Console.WriteLine("Decimal value of " + bin + " is " + sum);
    }
    public static void DecimalToBinary()
    {
        Console.WriteLine("Enter decimal number to be converted into binary");
        String dec = Console.ReadLine();
        int decimalValue = Int16.Parse(dec);

        String binary = "";
        while (decimalValue > 0)
        {
            int temp = decimalValue;
            temp = temp % 2;
            binary = temp.ToString() + binary;
                decimalValue = decimalValue / 2;
        }
        Console.WriteLine("Binary value of " + dec + " is " + binary);
    }
    public static void DecimalToOctal()
    {
        Console.WriteLine("Enter decimal number to be converted into octal");
        String dec = Console.ReadLine();
        int decimalValue = Int16.Parse(dec);

        String octal = "";
        while (decimalValue > 0)
        {
            int temp = decimalValue;
            temp = temp % 8;
            octal = octal + temp.ToString();
            decimalValue = decimalValue / 8;
        }
        Console.WriteLine("Octal value of " + dec + " is " + octal);
    }
    public static void DecimalToHex()
    {
        Console.WriteLine("Enter decimal number to be converted into Hexadecimal");
        String dec = Console.ReadLine();
        int decimalValue = Int16.Parse(dec);

        String hexadecimal = "";
        while (decimalValue > 0)
        {
            int temp = decimalValue;
            char a;
            temp = temp % 16;
            if (temp < 9)
            {
                a = (char)(temp + 48);
                hexadecimal = hexadecimal + a.ToString();
                decimalValue = decimalValue / 16;
            }
            else
            {
                a = (char)(temp + 55);
                hexadecimal = hexadecimal + a.ToString();
                decimalValue = decimalValue / 16;
            }
        }
        Console.WriteLine("Hex value of " + dec + " is " + hexadecimal);
        Console.Read();
    }

}
}
