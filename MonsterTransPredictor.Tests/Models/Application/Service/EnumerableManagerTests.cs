using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MonsterTransPredictor.Models.Application.Service.Tests
{
    [TestClass()]
    public class EnumerableManagerTests
    {
        [TestMethod()]
        public void MaxKeysTest()
        {
            var list = new List<(int x, float y)> {
                (2, 2),
                (6, -8),
                (-6, 8),
                (0, -1)
            };

            var result = list.MaxKeys(elem => Math.Abs(elem.x) + Math.Abs(elem.y));
            Assert.AreEqual(result.Count(), 2);

            var resultFirst = result.Single(elem => elem.x > 0);
            var resultSecond = result.Single(elem => elem.x < 0);
            Assert.AreEqual(6, resultFirst.x);
            Assert.AreEqual(-8, resultFirst.y);
            Assert.AreEqual(-6, resultSecond.x);
            Assert.AreEqual(8, resultSecond.y);
        }
        [TestMethod()]
        public void MinKeysTest()
        {
            var list = new List<(int x, float y)> {
                (6, 6),
                (3, -4),
                (-3, 4),
                (0, -8)
            };

            var result = list.MinKeys(elem => Math.Abs(elem.x) + Math.Abs(elem.y));
            Assert.AreEqual(result.Count(), 2);

            var resultFirst = result.Single(elem => elem.x > 0);
            var resultSecond = result.Single(elem => elem.x < 0);
            Assert.AreEqual(3, resultFirst.x);
            Assert.AreEqual(-4, resultFirst.y);
            Assert.AreEqual(-3, resultSecond.x);
            Assert.AreEqual(4, resultSecond.y);
        }
    }
}