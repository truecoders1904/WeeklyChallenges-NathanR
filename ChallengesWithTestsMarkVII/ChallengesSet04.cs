using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMarkVII
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    total = total + num;
                }
                else
                {
                    total = total - num;
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> strList = new List<int>();
            strList.Add(str1.Length);
            strList.Add(str2.Length);
            strList.Add(str3.Length);
            strList.Add(str4.Length);

            return strList.Min();

        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> newList = new List<int>();
            newList.Add(number1);
            newList.Add(number2);
            newList.Add(number3);
            newList.Add(number4);

            return newList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;

        }

        public bool IsStringANumber(string input)
        { 
            return double.TryParse(input, out double i);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            List<object> countOfObjects = new List<object>();
            List<object> countOfNulls = new List<object>();

            foreach (object obj in objs)
            {
                if (obj != null)
                {
                    countOfObjects.Add(obj);
                }

                if (obj == null)
                {
                    countOfNulls.Add(obj);
                }
            }

            if (countOfNulls.Count > countOfObjects.Count)
            {
                return true;
            }
            return false;
     

        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            List<int> onlyEvens = new List<int>();

            foreach (int evens in numbers)
            {
                if (evens % 2 == 0)
                {
                    onlyEvens.Add(evens);
                }
            }
            if (onlyEvens.Count ==0)
            {
                return 0;
            }
            int total = 0;
            foreach (int num in onlyEvens)
            {
                total = total + num;
            }
            double newAverage = (double)total / onlyEvens.Count;
            return newAverage;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
               result *= i;
            }


            return result;

        }
    }
}
