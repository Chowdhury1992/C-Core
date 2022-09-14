using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
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
                integerToString[i] = arr[i].ToString()!;
              //  Console.WriteLine(integerToString[i]);
            }
            return integerToString;

        }
        //Find the Largest Numbers in a Group of Arrays
        public static double[] MaximumNumberFinder(double[][]inputArr)
        {
            double[] arrayofMaximumNumbers = new double[inputArr.Length];
            double temp = double.MinValue;
         
            for(int i = 0; i<inputArr.Length;i++)
            {
                for(int j= 0; j < inputArr[i].Length;j++)
                {
                    if (inputArr[i][j] > temp )

                    {
                        temp = inputArr[i][j];
                    }
                }
                arrayofMaximumNumbers[i] = temp;
                temp = int.MinValue;
            }
            for (int i = 0; i < arrayofMaximumNumbers.Length; i++)
            {
                
                Console.WriteLine(arrayofMaximumNumbers[i]);
            }
            return arrayofMaximumNumbers;
        }

        //Collatz Conjecture
        static int count = 0;
        public static int CollatzConjecture(int n)
        {
            if (n > 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    count++;
                    CollatzConjecture(n);
                }
                else
                {
                    n = n * 3 + 1;
                    count++;
                    CollatzConjecture(n);
                }
            }
            return count;
        }
        //Find the Characters Counterpart Char Code
        public static int CounterpartCharCode(char charInput)
        {
            int charCode = 0;
            char temp = ' ';
            if( char.IsLower(charInput) ==true)
            {
              temp= char.ToUpper(charInput);
                charCode = (int)temp;
            }
            else if (char.IsUpper(charInput) == true)
            {
                temp = char.ToLower(charInput);
                charCode = (int)temp;
            }
            else if (char.IsDigit(charInput) == true)
            {
                charCode = (int)charInput;
            }
            return charCode;
        }
        //Count Ones in Binary Representation of Integer
        public static int CountOnes(int inputInt)
        {
            int count = 0;
            string binary = Convert.ToString(inputInt, 2);
            for(int i = 0; i<binary.Length;i++)
            {
                if (binary[i]=='1')
                {
                    count++;
                }
            }
            return count;
        }
        //Positive Count / Negative Sum
        public static int[] PositiveCountNegativeSum(double[] arrayofPositiveAndNegative)
        {
            int count = 0;
            int sumofNegativeNumbers = 0;
            int[] PositiveCountNegativeSum = new int[2];
            if (arrayofPositiveAndNegative.Length == 0)
            {
                PositiveCountNegativeSum = new int[0];
            }
            else
            {
                for (int i = 0; i < arrayofPositiveAndNegative.Length; i++)
                {
                    if (arrayofPositiveAndNegative[i] > 0)
                    {
                        count++;
                    }
                    else if (arrayofPositiveAndNegative[i] < 0)
                    {
                        sumofNegativeNumbers += (int)arrayofPositiveAndNegative[i];
                    }
                }

                PositiveCountNegativeSum[0] = count;
                PositiveCountNegativeSum[1] = sumofNegativeNumbers;
            }
                return PositiveCountNegativeSum;
        }
        //Fraction Greater Than One
        public static bool GreaterThanOne(string fraction)
        {
           
            string[] stringArray = fraction.Split('/');
            double numberValueHolder = Double.Parse(stringArray[0])/ Double.Parse(stringArray[1]) ;
           
            if (numberValueHolder > 1)
            {
                Console.WriteLine(numberValueHolder);
                return true;
            }
            else
            {
                Console.WriteLine(numberValueHolder);
                return false;
            }
        }

        //ATM PIN Code Validation
        public static bool ValidatePIN(string pin)
        {
            if(pin.Length==4 || pin.Length==6)
            {
                for(int i = 0; i<pin.Length; i++)
                {
                    if (!char.IsDigit(pin[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
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

            //Find the Largest Numbers in a Group of Arrays
            double[][] inputArr = new double[][]
            { 
                new double[]{0.4321, 0.7634, 0.652},
                new double[]{1.324, 9.32, 2.5423, 6.4314},
                new double[]{ 9, 3, 6, 3 } 
            } ;

            Console.WriteLine("Find the Largest Numbers in a Group of Arrays");
            MaximumNumberFinder(inputArr);

            //Collatz Conjecture
            Console.WriteLine("Collatz Conjecture");
            int n = 10;
            Console.WriteLine(CollatzConjecture(n));

            //Find the Characters Counterpart Char Code
            Console.WriteLine("Find the Characters Counterpart Char Code");
            char charInput = 'a';
            Console.WriteLine(CounterpartCharCode(charInput));

            //Count Ones in Binary Representation of Integer
            Console.WriteLine("Count Ones in Binary Representation of Integer");
            int inputInt = 999;
            Console.WriteLine(CountOnes(inputInt));

            //Positive Count / Negative Sum
            Console.WriteLine("Positive Count / Negative Sum");
            double[] arrayofPositiveAndNegative = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            Console.WriteLine(PositiveCountNegativeSum(arrayofPositiveAndNegative));

            //Fraction Greater Than One
            Console.WriteLine("Fraction Greater Than One");
            Console.WriteLine(GreaterThanOne("1/2"));

            //ATM PIN Code Validation
            Console.WriteLine("ATM PIN Code Validation");
            Console.WriteLine(ValidatePIN(""));
            
        }
    }
}