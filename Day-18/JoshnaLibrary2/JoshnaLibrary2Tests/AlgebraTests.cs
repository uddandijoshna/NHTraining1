﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using JoshnaLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshnaLibrary2.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]

        public void FactorialTest_Zero_Input()
        {
            // Arrange
            int n = 0;
            int expected = 1;
            // Act
            int actual = Algebra.Factorial(n);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_Negative_Input()
        {
            // Arrange
            int n = -3;
            int expected = -9999;
            // Act
            int actual = Algebra.Factorial(n);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_Greater_than_seven_Input()
        {
            // Arrange
            int n = 9;
            int expected = -999;
            // Act
            int actual = Algebra.Factorial(n);
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FactorialTest_Input()
        {
            // Arrange
            int n = 5;
            int expected = 120;
            // Act
            int actual = Algebra.Factorial(n);
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PalindromeTest_Input()
        {
            // Arrange
            int n = 131;
            bool expected = true;
            // Act
            bool actual = Algebra.IsPalindrome(n);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}