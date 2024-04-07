using System;
using System.Collections.Generic;
using System.Text;

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
        // Self-Reflection: This exercise helped me understand how to work with lists of data and how to use if-else statements in programming.
        public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                // Check if the array is empty
                if (nums.Length == 0) return 0;

                int index = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    // If current element is different from previous, increment index and replace value
                    if (nums[i] != nums[index])
                    {
                        index++;
                        nums[index] = nums[i];
                    }
                }
                // Return length of unique numbers
                return index + 1;
            }
            catch (Exception)
            {
                throw;
            }
        }


        // Question 2: Move Zeroes
        // Self-Reflection: Doing this task helped me learn more about loops, if-else statements, and changing lists of numbers.
        public static IList<int> MoveZeroes(int[] nums)
        {
            try
            {
                // Check if the array is null or empty
                if (nums == null || nums.Length == 0)
                    return new List<int>();

                int zeroCount = 0;

                // Iterate through the array
                for (int i = 0; i < nums.Length; i++)
                {
                    // Count zeroes
                    if (nums[i] == 0)
                    {
                        zeroCount++;
                    }
                    // Move non-zero elements to the left
                    else if (zeroCount > 0)
                    {
                        nums[i - zeroCount] = nums[i];
                        nums[i] = 0;
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
        // Self-Reflection: This problem made me better at arranging lists, sorting them, and using loops inside other loops.
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> result = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int left = i + 1, right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
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
        // Self-Reflection: This task helped me get better at using loops, if-else statements, and going through lists of data.


        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length == 0)
                    return 0;

                int maxCount = 0;
                int count = 0;
                foreach (var num in nums)
                {
                    if (num == 1)
                    {
                        count++;
                        maxCount = Math.Max(maxCount, count);
                    }
                    else
                        count = 0;
                }
                return maxCount;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 5: Binary to Decimal Conversion
        // Self-Reflection: This problem  helped me to understand better how to do math calculations and repeat steps over and over again.
        public static int BinaryToDecimal(int binary)
        {
            try
            {
                int decimalNumber = 0;
                int baseValue = 1;
                while (binary > 0)
                {
                    int remainder = binary % 10;
                    decimalNumber += remainder * baseValue;
                    binary /= 10;
                    baseValue *= 2;
                }
                return decimalNumber;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 6: Maximum Gap
        // Self-Reflection: This activity broadened my understanding of arranging lists, going through them, and finding the biggest differences..
        public static int MaximumGap(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length < 2)
                    return 0;

                Array.Sort(nums);
                int maxGap = 0;
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    maxGap = Math.Max(maxGap, nums[i + 1] - nums[i]);
                }
                return maxGap;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 7: Largest Perimeter Triangle
        // Self-Reflection: This task helped me get better at using loops, checking conditions, and sorting lists of numbers.







        public static int LargestPerimeter(int[] nums)
        {
            try
            {
                if (nums == null || nums.Length < 3)
                    return 0;

                Array.Sort(nums);
                for (int i = nums.Length - 1; i >= 2; i--)
                {
                    if (nums[i - 2] + nums[i - 1] > nums[i])
                        return nums[i - 2] + nums[i - 1] + nums[i];
                }
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Question 8: Remove Occurrences of a Substring
        // Self-Reflection: This activity helped me get better at playing around with words and doing things over and over again.
        public static string RemoveOccurrences(string s, string part)
        {
            try
            {
                while (s.Contains(part))
                {
                    int index = s.IndexOf(part);
                    s = s.Remove(index, part.Length);
                }
                return s;
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
