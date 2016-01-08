﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Project_Euler.Tools;

namespace Project_Euler.Tools_Tests
{
    [TestFixture]
    public class Sequences_Tests
    {
        private Sequences _target;

        [SetUp]
        public void SetUp()
        {
            _target = new Sequences();
        }


        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(10, 55)]
        [TestCase(12, 144)]
        public void Fibonacci_ReturnsCorrectResult_Test(int n, int expected)
        {
            var results = _target.GetFibonacciTerm(n);
            Assert.AreEqual((BigInteger)expected, results);
        }


    }
}
