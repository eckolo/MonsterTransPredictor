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
        public void MaxKeysTest_正常系_該当レコードが単数()
        {
            var list = new List<(int x, float y)> {
                (2, 2),
                (6, -8),
                (-3, 4),
                (0, -1)
            };

            var result = list.MaxKeys(elem => Math.Abs(elem.x) + Math.Abs(elem.y)).OrderBy(e => e.x).ToList();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            {
                var (resultX, resultY) = result[0];
                Assert.AreEqual(6, resultX);
                Assert.AreEqual(-8, resultY);
            }
        }
        [TestMethod()]
        public void MaxKeysTest_正常系_該当レコードが複数()
        {
            var list = new List<(int x, float y)> {
                (2, 2),
                (6, -8),
                (-6, 8),
                (0, -1)
            };

            var result = list.MaxKeys(elem => Math.Abs(elem.x) + Math.Abs(elem.y)).OrderBy(e => e.x).ToList();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            {
                var (resultX, resultY) = result[0];
                Assert.AreEqual(-6, resultX);
                Assert.AreEqual(8, resultY);
            }
            {
                var (resultX, resultY) = result[1];
                Assert.AreEqual(6, resultX);
                Assert.AreEqual(-8, resultY);
            }
        }
        [TestMethod()]
        public void MaxKeysTest_正常系_元のリストが空()
        {
            var list = new List<(int x, float y)> { };

            var result = list.MaxKeys(elem => Math.Abs(elem.x) + Math.Abs(elem.y));
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }
        [TestMethod()]
        public void MaxKeysTest_正常系_元のリストがNull()
        {
            List<(int x, float y)> list = null;

            var result = list.MaxKeys(elem => Math.Abs(elem.x) + Math.Abs(elem.y));
            Assert.IsNull(result);
        }
        [TestMethod()]
        public void MinKeysTest_正常系_該当レコードが単数()
        {
            var list = new List<(int x, float y)> {
                (6, 6),
                (6, -8),
                (-3, 4),
                (0, -8)
            };

            var result = list.MinKeys(elem => Math.Abs(elem.x) + Math.Abs(elem.y)).OrderBy(e => e.x).ToList();
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Count());
            {
                var (resultX, resultY) = result[0];
                Assert.AreEqual(-3, resultX);
                Assert.AreEqual(4, resultY);
            }
        }
        [TestMethod()]
        public void MinKeysTest_正常系_該当レコードが複数()
        {
            var list = new List<(int x, float y)> {
                (6, 6),
                (3, -4),
                (-3, 4),
                (0, -8)
            };

            var result = list.MinKeys(elem => Math.Abs(elem.x) + Math.Abs(elem.y)).OrderBy(e => e.x).ToList();
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count());
            {
                var (resultX, resultY) = result[0];
                Assert.AreEqual(-3, resultX);
                Assert.AreEqual(4, resultY);
            }
            {
                var (resultX, resultY) = result[1];
                Assert.AreEqual(3, resultX);
                Assert.AreEqual(-4, resultY);
            }
        }
        [TestMethod()]
        public void MinKeysTest_正常系_元のリストが空()
        {
            var list = new List<(int x, float y)> { };

            var result = list.MinKeys(elem => Math.Abs(elem.x) + Math.Abs(elem.y));
            Assert.IsNotNull(result);
            Assert.AreEqual(0, result.Count());
        }
        [TestMethod()]
        public void MinKeysTest_正常系_元のリストがNull()
        {
            List<(int x, float y)> list = null;

            var result = list.MinKeys(elem => Math.Abs(elem.x) + Math.Abs(elem.y));
            Assert.IsNull(result);
        }
    }
}