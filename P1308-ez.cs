using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System;

namespace Leetcode
{
    class P1308_ez
    {
        [Test]
        public void test1()
        {
            int[][] m = { new[]{ 1000, 1001 },new[]{ 1010, 1011 } };
            Assert.AreEqual(1000, m[0][0]);
            Assert.AreEqual(1001, m[0][1]);
            Assert.AreEqual(1010, m[1][0]);
            Assert.AreEqual(1011, m[1][1]);

            int[,] mm = { { 1000, 1001 }, { 1010, 1011 } };
            Assert.AreEqual(1000, mm[0,0]);
            Assert.AreEqual(1001, mm[0,1]);
            Assert.AreEqual(1010, mm[1,0]);
            Assert.AreEqual(1011, mm[1,1]);

            int[][] arr = { new[] { 1, 2 }, new[] { 3, 4 } };
        }

        public int[] GetMagicNumbers(int[][] matrix)
        {
            return new int[] { 1, 2 };
        }
    }

}

