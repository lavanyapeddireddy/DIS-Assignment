using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Remove Duplicates from Sorted Array
            Console.WriteLine("Question 1 and Output2:");
            int[] nums1_1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers1 = RemoveDuplicates(nums1_1);
            Console.WriteLine(numberOfUniqueNumbers1);

            // Example 1.2
            Console.WriteLine("Question 1 and Output1:");
            int[] nums1_2 = { 1, 1, 2 };
            int numberUniqueNumbers1 = RemoveDuplicates(nums1_2);
            Console.WriteLine(numberUniqueNumbers1);


            // Question 2: Move Zeroes
            Console.WriteLine("Question 2 and Output1:");
            int[] nums2_1 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero1 = MoveZeroes(nums2_1);
            string combinationsString1 = ConvertIListToArray(resultAfterMovingZero1);
            Console.WriteLine(combinationsString1);

            // Example 2.2 :
            Console.WriteLine("Question 2 and Output2:");
            int[] nums2_2 = { 0 };
            IList<int> AfterMovingZero1 = MoveZeroes(nums2_2);
            string combinationString1 = ConvertIListToArray(AfterMovingZero1);
            Console.WriteLine(combinationString1);

            // Question 3: 3Sum
            Console.WriteLine("Question 3 and Output1:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets1 = ThreeSum(nums3);
            string tripletResult1 = ConvertIListToNestedList(triplets1);
            Console.WriteLine(tripletResult1);

            // Example 3.2 :
            Console.WriteLine("Question 3 and output2:");
            int[] nums3_1 = { 0, 1, 1 };
            IList<IList<int>> triplet1 = ThreeSum(nums3_1);
            string tripletsResult1 = ConvertIListToNestedList(triplet1);
            Console.WriteLine(tripletsResult1);

            // Example 3.3 :
            Console.WriteLine("Question 3 and Output3:");
            int[] nums3_2 = { 0, 0, 0 };
            IList<IList<int>> triplet2 = ThreeSum(nums3_2);
            string tripletsResult2 = ConvertIListToNestedList(triplet2);
            Console.WriteLine(tripletsResult2);

            // Question 4: Max Consecutive Ones
            Console.WriteLine("Question 4 and Output1:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes1 = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes1);

            // Example 4.2:
            Console.WriteLine("Question 4 and Output2:");
            int[] nums4_2 = { 1, 0, 1, 1, 0, 1 };
            int maxOne1 = FindMaxConsecutiveOnes(nums4_2);
            Console.WriteLine(maxOne1);

            // Question 5: Binary to Decimal Conversion
            Console.WriteLine("Question 5 and Output1:");
            int binaryInput1 = 101010;
            int decimalResult1 = BinaryToDecimal(binaryInput1);
            Console.WriteLine(decimalResult1);

            // Question 6: Maximum Gap
            Console.WriteLine("Question 6 and Output1:");
            int[] nums5 = { 3, 6, 9, 1 };
            int maxGap1 = MaximumGap(nums5);
            Console.WriteLine(maxGap1);

            // Example 6.2:
            Console.WriteLine("Question 6 and Output2:");
            int[] nums5_1 = { 10 };
            int maxGapp1 = MaximumGap(nums5_1);
            Console.WriteLine(maxGapp1);



            // Question 7: Largest Perimeter Triangle
            Console.WriteLine("Question 7 and Output1:");
            int[] nums6 = { 2, 1, 2 };
            int largestPerimeterResult1 = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult1);

            // Example 7.2:
            Console.WriteLine("Question 7 and Output2:");
            int[] nums6_2 = { 1, 2, 1, 10 };
            int largestPeriResult1 = LargestPerimeter(nums6_2);
            Console.WriteLine(largestPeriResult1);

            // Question 8: Remove Occurrences of a Substring
            Console.WriteLine("Question 8 and Output1:");
            string result1 = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result1);

            // Example 8.2:
            Console.WriteLine("Question 8 and Output2:");
            string r1 = RemoveOccurrences("axxxxyyyyb", "xy");
            Console.WriteLine(r1);
        }

        // Question 1: Remove Duplicates from Sorted Array
        // Self-Reflection: I learned about manipulating arrays effectively and the significance of concise exception handling to ensure code reliability.
            public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                // Check if the array is empty
                if (nums.Length == 0) return 0;

                int uniqueIndex = 0;
                for (int currentIndex = 1; currentIndex < nums.Length; currentIndex++)
                {
                    // If the current item is not the same as the one before it, move to the next spot and change what's there.
                    if (nums[currentIndex] != nums[uniqueIndex])
                    {
                        uniqueIndex++;
                        nums[uniqueIndex] = nums[currentIndex];
                    }
                }
                // Return the count of distinct numbers.
                return uniqueIndex + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Question 2: Move Zeroes
        // Self-Reflection:Through this task I learned how to move zeros to the end of an array while keeping other elements in order, and why handling errors properly is crucial for reliable code.
        public static IList<int> MoveZeroes(int[] nums)
        {
            try
            {
                // Checking the array is null or empty
                if (nums == null || nums.Length == 0)
                    return new List<int>();

                int zeroCount = 0;

                // Go through the list one item at a time.
                for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
                {
                    // Counting the zeroes
                    if (nums[currentIndex] == 0)
                    {
                        zeroCount++;
                    }
                    // Shift all non-zero elements to the beginning.
                    else if (zeroCount > 0)
                    {
                        nums[currentIndex - zeroCount] = nums[currentIndex];
                        nums[currentIndex] = 0;
                    }
                }

                return nums;
            }
            catch (Exception)
            {
                throw;
            }
        }



        // Question 3: 3Sum
        // Self-Reflection: This task made me to find sets of three numbers that add up to zero in a sorted list, without repeating the same combination, improving my understanding of array manipulation..
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();

            for (int firstIndex = 0; firstIndex < nums.Length - 2; firstIndex++)
            {
                if (firstIndex > 0 && nums[firstIndex] == nums[firstIndex - 1]) continue;
                int left = firstIndex + 1, right = nums.Length - 1;
                while (left < right)
                {
                    // Calculate the sum of the current triplet
                    int sum = nums[firstIndex] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[firstIndex], nums[left], nums[right] });
                        // Skip duplicates for the second and third elements
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                        left++;
                    else
                        right--;
                }
            }

            return result;
        }


        // Question 4: Max Consecutive Ones
        // Self-Reflection: This task helped me count the longest sequence of ones in an array, improving my grasp of loops and keeping track of variables.
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length == 0)
                    return 0;
                // Initialize variables to keep track of the maximum consecutive ones and the current count of consecutive ones
                int maxConsecutiveOnes = 0;
                int currentConsecutiveOnes = 0;
                foreach (var num in nums)
                {
                    if (num == 1)
                    {
                        currentConsecutiveOnes++;
                        maxConsecutiveOnes = Math.Max(maxConsecutiveOnes, currentConsecutiveOnes);
                    }
                    else
                        currentConsecutiveOnes = 0;
                }
                return maxConsecutiveOnes;
            }
            catch (Exception)
            {
                throw;
            }
        }




        // Question 5: Binary to Decimal Conversion
        // Self-Reflection: Through this code, I learned how to convert a binary number to its decimal equivalent using basic arithmetic operations and iterative processing, enhancing my understanding of number systems and loops.
        public static int BinaryToDecimal(int num)
        {
            try
            {
                int decimalNumber = 0;
                int baseValue = 1;
                while (num > 0)
                {
                    int remainder = num % 10;
                    // Update the decimal number by adding the contribution of the current digit.
                    decimalNumber += remainder * baseValue;
                    num /= 10;
                    baseValue *= 2;
                }
                // Return the decimal representation of the binary input.
                return decimalNumber;
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Question 6: Maximum Gap
        // Self-Reflection:Through this code, I learned how to find the maximum difference between successive elements in a sorted array, aiding in understanding basic array manipulation and finding extremities within data.
        public static int MaximumGap(int[] nums)
        {
            try
            {
                // Check if the input array is null or has less than 2 elements.
                // If so, there are no differences to calculate, return 0.
                if (nums == null || nums.Length < 2)
                    return 0;

                Array.Sort(nums);
                // Initialize a variable to store the maximum difference
                int maxDifference = 0;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    maxDifference = Math.Max(maxDifference, nums[i + 1] - nums[i]);
                }
                return maxDifference;
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Question 7: Largest Perimeter Triangle
        // Self-Reflection: Through this code, I learned how to determine the largest perimeter possible from a given set of side lengths, practicing array sorting and iteration techniques to find the optimal solution.
        public static int LargestPerimeter(int[] sideLengths)
        {
            try
            {
                if (sideLengths == null || sideLengths.Length < 3)
                    return 0;

                Array.Sort(sideLengths);
                // Iterate through the sorted array from the largest elements to find the largest perimeter.
                for (int i = sideLengths.Length - 1; i >= 2; i--)
                {
                    if (sideLengths[i - 2] + sideLengths[i - 1] > sideLengths[i])
                        return sideLengths[i - 2] + sideLengths[i - 1] + sideLengths[i];
                }
                // If no valid perimeter is found, return 0.
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Question 8: Remove Occurrences of a Substring
        // Self-Reflection: This activity helped me to learn to delete all instances of a word from a sentence and how to turn lists and arrays into readable strings.
        public static string RemoveOccurrences(string inputString, string substring)
        {
            try
            {
                // Iterate through the input string while it contains the specified substring.
                // Remove each leftmost occurrence of the substring.
                while (inputString.Contains(substring))
                {
                    int index = inputString.IndexOf(substring);
                    inputString = inputString.Remove(index, substring.Length);
                }
                // Return the modified string after removing all occurrences of the substring.
                return inputString;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /* Inbuilt Functions - Don't Change the below functions */
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }


        static string ConvertIListToArray(IList<int> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }
    }
    }
