using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

namespace CSharpCorePractice
{
    public class Program
    {
        //finding number of true values in an array
        public static int NumberofTrues(bool[] trueorFalse)
        {
            int numberOfTrues = 0;
            for (int i = 0; i<trueorFalse.Length;i++)
            {
                if (trueorFalse[i]==true)
                {
                    numberOfTrues++;
                }
            }
            return numberOfTrues;
        }

        //creating array that values are multiples of a given number
        public static int[] multiplesOfAGivenNumber(int givenNumber, int arrLength)
        {
            int[] arrayofMultipleValues = new int[arrLength];
            arrayofMultipleValues[0] = givenNumber;
            for (int i = 1; i < arrLength; i++)
            {

                   arrayofMultipleValues[i] = givenNumber * (i+1);
                Console.WriteLine(arrayofMultipleValues[i] + " ");
            }
            
                return arrayofMultipleValues;

        }
        //reversing the case
        public static string ReverseTheCase(string input)
        {
            string output = string.Empty;
            char[] arr = input.ToCharArray();
            for(int i = 0; i<input.Length; i++)
            {
                if (char.ToLower(input[i]) == input[i])
                {
                    output += char.ToUpper(input[i]);
                }
                else if (char.ToUpper(input[i]) == input[i])
                {
                    output+=char.ToLower(input[i]);
                }
            }
            return output;
        }
        //checking the equality of value and type
        public static bool CheckEquality(object a, object b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //return the index of all capital letters
        public static List<int> IndexofAllCapitalLetters(string input)
        {
            List<int> indexOfCapitalLettters = new List<int>();
         
            for (int i = 0; i < input.Length; i++)
            {
                if (char.ToUpper(input[i]) == input[i])
                {
                    
                  indexOfCapitalLettters.Add(i);
                  
                   
                }
            }
            for (int i = 0; i < indexOfCapitalLettters.Count; i++)
            {
                Console.WriteLine(indexOfCapitalLettters[i]);
            }
            return indexOfCapitalLettters;
        }
        //finding a spcific word
        public static string findTheBomb(string bomb)
        {
            string modifiedToLower = bomb.ToLower();
            if (modifiedToLower.Contains("bomb"))
            {
                return "Duck!!!";
            }
            else
            {
                return "There is no bomb, relax.";
            }
        }
        //Convert All Array Items to String
        public static string[] ConvertAllArrayItemstoString(object[]arr)
        {
            string[] integerToString = new string[arr.Length];
            
            for(int i = 0; i<arr.Length;i++)
            {
                integerToString[i] = arr[i].ToString();
                Console.WriteLine(integerToString[i]);
            }
            return integerToString;

        }

        static void Main(string[] args)
        {
            //finding number of true values in an array
            Console.WriteLine("finding number of true values in an array");
            bool[] trueorFalse = { true, false, false, true, false };
            Console.WriteLine(NumberofTrues(trueorFalse));

            //creating array that values are multiples of a given number
            Console.WriteLine("creating array that values are multiples of a given number");
            int givenNumber = 17;
            int arrLength = 6;
            multiplesOfAGivenNumber(givenNumber, arrLength);

            //reversing the case
            Console.WriteLine("reversing the case");
            string input = "MANY THANKS";
            Console.WriteLine(ReverseTheCase(input));

            //checking the equality of value and type;
            Console.WriteLine("checking the equality of value and type");
            Console.WriteLine(CheckEquality(1, true));
            Console.WriteLine(CheckEquality(0, "0"));
            Console.WriteLine(CheckEquality(1, 1));
            Console.WriteLine(CheckEquality("1", "a"));

            //return the index of all capital letters
            Console.WriteLine("return the index of all capital letters");
            IndexofAllCapitalLetters("eDaBiT");

            //finding a spcific word
            Console.WriteLine("finding a spcific word");
            Console.WriteLine(findTheBomb("There is a BOMB."));
            Console.WriteLine(findTheBomb("Hey, did you think there is a bomb?"));
            Console.WriteLine(findTheBomb("This goes boom!!!"));

            //Convert All Array Items to String
            object[] arr = { 1, 2, "a", "b" };
            Console.WriteLine("Convert All Array Items to String");
            Console.WriteLine(ConvertAllArrayItemstoString(arr));
        }
    }
}