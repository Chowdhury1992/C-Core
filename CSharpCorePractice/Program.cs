using System.Diagnostics.Metrics;

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
                Console.Write(arrayofMultipleValues[i] + " ");
            }
            
                return arrayofMultipleValues;

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
            
        }
    }
}