using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number");
            String number = Console.ReadLine();

            String answer1 = getNameFromNumber1(number);
            String answer2 = getNameFromNumber2(number);
            Console.WriteLine("Converted form 1 : " + answer1);
            Console.WriteLine("Converted form 2 : " + answer2);
            Console.Read();


        }
        public static string sixDigitNumber(string number)
        {
            string ans = "";
            char[] arrayOfNumber = number.ToCharArray();
            if (arrayOfNumber[0] == 0)
            {
                ans += fiveDigitNumber(number);
                return ans;
            }
            else
            {
                ans += getNameFromNumber1(arrayOfNumber[0].ToString());
                ans += "lakh ";
                number = arrayOfNumber[1].ToString() + arrayOfNumber[2].ToString() + arrayOfNumber[3].ToString() + arrayOfNumber[4].ToString() + arrayOfNumber[5].ToString();
                ans += fiveDigitNumber(number);
                return ans;
            }
        }
        public static string fiveDigitNumber(string number)
        {
            string ans = "";
            char[] arrayOfNumber = number.ToCharArray();
            if (arrayOfNumber[0] == 0)
            {
                ans += fourDigitNumber(number);
                return ans;
            }
            else
            {
                ans += twoDigitNumber(arrayOfNumber[0].ToString() + arrayOfNumber[1].ToString());
                ans += " thousand ";
                number = arrayOfNumber[2].ToString() + arrayOfNumber[3].ToString() + arrayOfNumber[4].ToString();
                ans += threeDigitNumber(number);
                return ans;
            }
        }
        public static string fourDigitNumber(String number)
        {
            string ans = "";
            char[] arrayOfNumber = number.ToCharArray();
            if (arrayOfNumber[0] == 0)
            {
                ans += threeDigitNumber(number);
                return ans;
            }
            else
            {
                ans += getNameFromNumber1(arrayOfNumber[0].ToString());
                ans += " thousand ";
                number = arrayOfNumber[1].ToString() + arrayOfNumber[2].ToString() + arrayOfNumber[3].ToString();
                ans += threeDigitNumber(number);
                return ans;
            }
        }
        public static string threeDigitNumber(String number)
        {
            string ans = "";
            char[] arrayOfNumber = number.ToCharArray();


            if (arrayOfNumber[0] == 0)
            {
                ans += twoDigitNumber(number);
                return ans;
            }
            else
            {
                ans += getNameFromNumber1(arrayOfNumber[0].ToString());
                ans += "hundred ";
                number = arrayOfNumber[1].ToString() + arrayOfNumber[2].ToString();
                ans += twoDigitNumber(number);
                return ans;
            }


        }
        public static string twoDigitNumber(String number)
        {
            string ans = "";
            char[] arrayOfNumber = number.ToCharArray();
            switch (arrayOfNumber[0])
            {
                case '0':
                    ans = getNameFromNumber1(number);
                    break;

                case '1':
                    switch (arrayOfNumber[1])
                    {
                        case '0':
                            ans += "ten";
                            break;
                        case '1':
                            ans += "eleven";
                            break;
                        case '2':
                            ans += "twelve";
                            break;
                        case '3':
                            ans += "thirteen";
                            break;
                        case '4':
                            ans += "fourteen";
                            break;
                        case '5':
                            ans += "fifteen";
                            break;
                        case '6':
                            ans += "sixteen";
                            break;
                        case '7':
                            ans += "seventeen";
                            break;
                        case '8':
                            ans += "eighteen";
                            break;
                        case '9':
                            ans += "ninteen";
                            break;
                    }
                    break;
                case '2':
                    ans += "twenty ";
                    if (arrayOfNumber[1] == 0)
                    {
                        break;
                    }
                    else
                    {
                        ans += getNameFromNumber1(arrayOfNumber[1].ToString());
                        break;
                    }
                case '3':
                    ans += "thirty ";
                    if (arrayOfNumber[1] == 0)
                    {
                        break;
                    }
                    else
                    {
                        ans += getNameFromNumber1(arrayOfNumber[1].ToString());
                        break;
                    }
                case '4':
                    ans += "fourty ";
                    if (arrayOfNumber[1] == 0)
                    {
                        break;
                    }
                    else
                    {
                        ans += getNameFromNumber1(arrayOfNumber[1].ToString());
                        break;
                    }
                case '5':
                    ans += "fifty ";
                    if (arrayOfNumber[1] == 0)
                    {
                        break;
                    }
                    else
                    {
                        ans += getNameFromNumber1(arrayOfNumber[1].ToString());
                        break;
                    }

                case '6':
                    ans += "sixty ";
                    if (arrayOfNumber[1] == 0)
                    {
                        break;
                    }
                    else
                    {
                        ans += getNameFromNumber1(arrayOfNumber[1].ToString());
                        break;
                    }
                case '7':
                    ans += "seventy ";
                    if (arrayOfNumber[1] == 0)
                    {
                        break;
                    }
                    else
                    {
                        ans += getNameFromNumber1(arrayOfNumber[1].ToString());
                        break;
                    }
                case '8':
                    ans += "eighty ";
                    if (arrayOfNumber[1] == 0)
                    {
                        break;
                    }
                    else
                    {
                        ans += getNameFromNumber1(arrayOfNumber[1].ToString());
                        break;
                    }
                case '9':
                    ans += "ninety ";
                    if (arrayOfNumber[1] == 0)
                    {
                        break;
                    }
                    else
                    {
                        ans += getNameFromNumber1(arrayOfNumber[1].ToString());
                        break;
                    }
            }
            return ans;
        }
        public static String getNameFromNumber1(String number)
        {
            char[] seperatedNumber = number.ToCharArray();
            String ans = "";
            for (int i = 0; i < seperatedNumber.Length; i++)
            {
                switch (seperatedNumber[i])
                {
                    case '0':
                        ans += " zero ";
                        break;
                    case '1':
                        ans += " one ";
                        break;
                    case '2':
                        ans += " two ";
                        break;
                    case '3':
                        ans += " three ";
                        break;
                    case '4':
                        ans += " four ";
                        break;
                    case '5':
                        ans += " five ";
                        break;
                    case '6':
                        ans += " six ";
                        break;
                    case '7':
                        ans += " seven ";
                        break;
                    case '8':
                        ans += " eight ";
                        break;
                    case '9':
                        ans += " nine ";
                        break;

                }
            }
            return ans;
        }

        public static String getNameFromNumber2(String number)
        {
            char[] arrayOfNumber = number.ToCharArray();
            String ans = "";
            int size = arrayOfNumber.Length;
            int n = size - 1;
            if (size == 1)
            {
                ans = getNameFromNumber1(number);
                return ans;
            }
            if (size == 2)
            {
                ans = twoDigitNumber(number);
                return ans;
            }
            if (size == 3)
            {
                ans = threeDigitNumber(number);
                return ans;
            }
            if (size == 4)
            {
                ans = fourDigitNumber(number);
                return ans;
            }
            if (size == 5)
            {
                ans = fiveDigitNumber(number);
                return ans;
            }
            if (size == 6)
            {
                ans = sixDigitNumber(number);
                return ans;
            }

            else
            {
                Console.WriteLine("Only numbers upto 5 digits can be converted");
                return ans;
            }

        }

    }
}
