using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace ExerciseTests
{
    [TestClass]
    public class MedianTests
    {
        [TestMethod]
        public void I_Median_Array1()
        {
            // Arrange
            int[] testArr = { 1, 2, 3 };
            int expected = 2;
            int actual;

            // Act
            actual = Exercise.Median(testArr);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void I_Median_Array2()
        {
            // Arrange
            Exercise exercise = new Exercise();
            int[] testArr = { 3, 4, 5 };
            int expected = 4;
            int actual;

            // Act
            actual = Exercise.Median(testArr);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
