using System;
using NUnit.Framework;
using sharp_koans.Helpers;

namespace sharp_koans.Koans
{
    public class Arrays : Koan
    {
        [Test]
        public void CreatingArrays()
        {
            var emptyArray = new object[] { };
            Assert.AreSame(____, emptyArray.GetType(), "An array is a data structure that contains several variables of the same type.");

            // An array can be Single-Dimensional, Multidimensional or Jagged.
            int[,] multiDimensionalArray1 = new int[2, 3];
            int[][] jaggedArray = new int[6][];
            // point differences

            int[] singleDimensionalArrayWithDefaultValues = new int[6];
            Assert.AreEqual(____, singleDimensionalArrayWithDefaultValues[0], "The default value of numeric array elements are set to zero, and reference elements are set to null.");

            int[][] jaggedArrayWithDefaultValues = new int[6][];
            Assert.AreEqual(____, jaggedArrayWithDefaultValues[0], "A jagged array is an array of arrays, and therefore its elements are reference types and are initialized to null.");
        }

        [Test]
        public void IndexingArrays()
        {
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };

            Assert.AreEqual(____, numbers[1], "Arrays are zero indexed: an array with n elements is indexed from 0 to n-1.");

            try
            {
                int thereIsNoSuchIndex = numbers[9];
            }
            catch (Exception e)
            {
                Assert.AreSame(____, e.GetType(), "Arrays are zero indexed: an array with n elements is indexed from 0 to n-1.");
            }
        }

        [Test]
        public void ArrayCanBeOfAnyType()
        {
            CustomType[] arrayOfCustomTypes = new CustomType[] { new CustomType() };
            Assert.AreSame(____, arrayOfCustomTypes.GetType(), "Array elements can be of any type, including an array type.");

            int[] array = { 1, 2, 3 };
            ChangeSecondElementOfArrayToOne(array);
            Assert.AreEqual(____, array[1], "Array types are reference types derived from the abstract base type Array");
        }


        [Test]
        public void IteratingArrays()
        {
            // Since this type implements IEnumerable and IEnumerable<T>, you can use foreach iteration on all arrays in C#.
            int[] array = { 1, 2, 3 };
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Array.ForEach(array, Console.WriteLine);
        }

        [Test]
        public void ArrayMethods()
        {
            // TODO: add tests for array methods    
        }

        public static void ChangeSecondElementOfArrayToOne(Array array)
        {
            array.SetValue(1, 1);
        }
    }
}