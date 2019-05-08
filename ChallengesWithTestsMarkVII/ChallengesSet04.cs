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
            throw new NotImplementedException();
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
            if (objs == null)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
           
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
