using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars_FindLongestGap
{
    public static class Kata
    {
        public static int Gap(int num)
        {
            string binaryNum = GetBinaryRepresentation(num);

            if (TestForZeroes(binaryNum))
            {
                List<int> onePositions = GetPositionsOfOnes(binaryNum);
                List<int> gapLengths = GetBinaryGapLengths(onePositions);
                int longestGap = GetLongestGap(gapLengths);
                return longestGap;
            }
            else
            {
                return 0; //end the program
            }
        }

        //Get the binary representation of a decimal number.
        public static string GetBinaryRepresentation(int num)
        {
            string result = Convert.ToString(num, 2);
            //Console.WriteLine("Binary Number: " + result);
            return result;
        }

        //Test to see if there are any zeroes. If there are then that means there is possibly a binary gap.
        public static bool TestForZeroes(string binaryNum)
        {
            if (binaryNum.Contains('0'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //get the positions of all the ones
        public static List<int> GetPositionsOfOnes(string binaryNum)
        {
            List<int> onePositions = new List<int>();

            int position = binaryNum.IndexOf('1', 0);

            do
            {
                //Console.WriteLine("Position of 1: " + position);
                onePositions.Add(position);
                position = binaryNum.IndexOf('1', position + 1);
            } while (position != -1); //position != the ending string position

            return onePositions;
        }

        public static List<int> GetBinaryGapLengths(List<int> onePositions)
        {
            List<int> gapLengths = new List<int>();

            for (int i = 0; i < onePositions.Count() - 1; i++)
            {
                int difference = onePositions[i + 1] - onePositions[i];

                if (difference > 1)
                {
                    gapLengths.Add(difference - 1);
                }
            }

            return gapLengths;
        }

        public static int GetLongestGap(List<int> gapLengths)
        {
            int longestGap = 0;

            for (int i = 0; i < gapLengths.Count(); i++)
            {
                if (gapLengths[i] > longestGap)
                {
                    longestGap = gapLengths[i];
                }
            }

            return longestGap;
        }
    }
}

//A binary gap within a positive number num is any sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of num. 
//For example:
//9 has binary representation 1001 and contains a binary gap of length 2.
//529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3.
//20 has binary representation 10100 and contains one binary gap of length 1.
//15 has binary representation 1111 and has 0 binary gaps.
//Write function gap(num) that, given a positive num, returns the length of its longest binary gap.
//The function should return 0 if num doesn't contain a binary gap.

