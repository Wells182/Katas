using System;
using Xunit;

namespace GreenValley
{
    public class ValleyTests
    {
        static void testing(string actual, string expected)
        {
            Assert.Equal(expected, actual);
        }

        static string Array2String(int[] list)
        {
            return "[" + string.Join(",", list) + "]";
        }

        [Fact]
        public static void test0()
        {
            Console.WriteLine("Fixed Tests");
            int[] a = new int[] { 17, 17, 15, 14, 8, 7, 7, 5, 4, 4, 1 };
            int[] r = new int[] { 17, 15, 8, 7, 4, 1, 4, 5, 7, 14, 17 };
            testing(Array2String(Valley.MakeValley(a)), Array2String(r));
            a = new int[] { 20, 7, 6, 2 }; r = new int[] { 20, 6, 2, 7 };
            testing(ValleyTests.Array2String(Valley.MakeValley(a)), ValleyTests.Array2String(r));
            a = new int[] { }; r = new int[] { };
            testing(ValleyTests.Array2String(Valley.MakeValley(a)), ValleyTests.Array2String(r));
            a = new int[] { 14, 10, 8 }; r = new int[] { 14, 8, 10 };
            testing(ValleyTests.Array2String(Valley.MakeValley(a)), ValleyTests.Array2String(r));
            a = new int[] { 20, 18, 17, 13, 12, 12, 10, 9, 4, 2, 2, 1, 1 };
            r = new int[] { 20, 17, 12, 10, 4, 2, 1, 1, 2, 9, 12, 13, 18 };
            testing(ValleyTests.Array2String(Valley.MakeValley(a)), ValleyTests.Array2String(r));
            a = new int[] { 20, 16, 14, 10, 1 }; r = new int[] { 20, 14, 1, 10, 16 };
            testing(ValleyTests.Array2String(Valley.MakeValley(a)), ValleyTests.Array2String(r));
            a = new int[] { 19, 19, 18, 14, 12, 11, 9, 7, 4 };
            r = new int[] { 19, 18, 12, 9, 4, 7, 11, 14, 19 };
            testing(ValleyTests.Array2String(Valley.MakeValley(a)), ValleyTests.Array2String(r));
            a = new int[] { 20, 18, 16, 15, 14, 14, 13, 13, 10, 9, 4, 4, 4, 1 };
            r = new int[] { 20, 16, 14, 13, 10, 4, 4, 1, 4, 9, 13, 14, 15, 18 };
            testing(ValleyTests.Array2String(Valley.MakeValley(a)), ValleyTests.Array2String(r));
            a = new int[] { 20, 20, 16, 14, 12, 12, 11, 10, 3, 2 };
            r = new int[] { 20, 16, 12, 11, 3, 2, 10, 12, 14, 20 };
            testing(ValleyTests.Array2String(Valley.MakeValley(a)), ValleyTests.Array2String(r));
            a = new int[] { 19, 17, 16, 15, 13, 8, 5, 5, 4, 4, 4 };
            r = new int[] { 19, 16, 13, 5, 4, 4, 4, 5, 8, 15, 17 };
            testing(ValleyTests.Array2String(Valley.MakeValley(a)), ValleyTests.Array2String(r));
            a = new int[] { 19, 8, 6 }; r = new int[] { 19, 6, 8 };
            testing(ValleyTests.Array2String(Valley.MakeValley(a)), ValleyTests.Array2String(r));
        }

        [Theory]
        [InlineData(new int[] { 17, 17, 15, 14, 8, 7, 7, 5, 4, 4, 1 })]
        [InlineData(new int[] { 20, 7, 6, 2 })]
        [InlineData(new int[] { 14, 10, 8 })]
        [InlineData(new int[] { 20, 18, 17, 13, 12, 12, 10, 9, 4, 2, 2, 1, 1 })]
        [InlineData(new int[] { 20, 16, 14, 10, 1 })]
        [InlineData(new int[] { 19, 19, 18, 14, 12, 11, 9, 7, 4 })]
        [InlineData(new int[] { 20, 18, 16, 15, 14, 14, 13, 13, 10, 9, 4, 4, 4, 1 })]
        [InlineData(new int[] { 20, 20, 16, 14, 12, 12, 11, 10, 3, 2 })]
        [InlineData(new int[] { 19, 17, 16, 15, 13, 8, 5, 5, 4, 4, 4 })]
        [InlineData(new int[] { 19, 8, 6 })]
        public static void MakeValley_ShouldReturnArrayWithLargestAtStartAndEnd(int[] numbers)
        {
            var result = Valley.MakeValley(numbers);
            Assert.Equal(numbers[0], result[0]);
            Assert.Equal(numbers[1], result[result.Length - 1]);
        }

        [Theory]
        [InlineData(new int[] { 17, 17, 15, 14, 8, 7, 7, 5, 4, 4, 1 })]
        [InlineData(new int[] { 20, 7, 6, 2 })]
        [InlineData(new int[] { 14, 10, 8 })]
        [InlineData(new int[] { 20, 18, 17, 13, 12, 12, 10, 9, 4, 2, 2, 1, 1 })]
        [InlineData(new int[] { 20, 16, 14, 10, 1 })]
        [InlineData(new int[] { 19, 19, 18, 14, 12, 11, 9, 7, 4 })]
        [InlineData(new int[] { 20, 18, 16, 15, 14, 14, 13, 13, 10, 9, 4, 4, 4, 1 })]
        [InlineData(new int[] { 20, 20, 16, 14, 12, 12, 11, 10, 3, 2 })]
        [InlineData(new int[] { 19, 17, 16, 15, 13, 8, 5, 5, 4, 4, 4 })]
        [InlineData(new int[] { 19, 8, 6 })]
        public static void MakeValley_ShouldReturnArrayWithSecondIndexSmallerThanFirst(int[] numbers)
        {
            var result = Valley.MakeValley(numbers);
            Assert.True(result[0] > result[1]);
            Assert.True(result[result.Length-1] > result[result.Length - 2]);
        }
    }
}
