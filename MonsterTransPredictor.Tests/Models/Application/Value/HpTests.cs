using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MonsterTransPredictor.Models.Application.Value.Tests
{
    [TestClass()]
    public class HpTests
    {
        [TestMethod()]
        public void HpTest_正常系_uint()
        {
            const uint num = 5;

            var result = new Hp(num);

            Assert.IsNotNull(result);
            Assert.AreEqual(num, result.real);
        }
        [TestMethod()]
        public void HpTest_正常系_int()
        {
            const int num = 5;

            var result = new Hp(num);

            Assert.IsNotNull(result);
            Assert.AreEqual(num, (int)result.real);
        }
        [TestMethod()]
        public void HpTest_異常系_intで負の値が入る()
        {
            const int num = -3;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Hp(num));
        }

        readonly Hp large = new Hp(17);
        readonly Hp small = new Hp(3);
        readonly Hp small2 = new Hp(3);
        readonly Hp nullValue = null;

        [TestMethod()]
        public void CompareToTest_正常系_メソッド()
        {
            Assert.AreEqual(0, large.CompareTo(large));
            Assert.AreEqual(1, large.CompareTo(small));
            Assert.AreEqual(1, large.CompareTo(small2));

            Assert.AreEqual(-1, small.CompareTo(large));
            Assert.AreEqual(0, small.CompareTo(small));
            Assert.AreEqual(0, small.CompareTo(small2));

            Assert.AreEqual(-1, small2.CompareTo(large));
            Assert.AreEqual(0, small2.CompareTo(small));
            Assert.AreEqual(0, small2.CompareTo(small2));
        }
        [TestMethod()]
        public void CompareToTest_正常系_演算子_小なり()
        {
#pragma warning disable CS1718 // 同じ変数との比較もテストする
            Assert.IsFalse(large < large);
            Assert.IsFalse(large < small);
            Assert.IsFalse(large < small2);

            Assert.IsTrue(small < large);
            Assert.IsFalse(small < small);
            Assert.IsFalse(small < small2);

            Assert.IsTrue(small2 < large);
            Assert.IsFalse(small2 < small);
            Assert.IsFalse(small2 < small2);
#pragma warning restore CS1718 // 同じ変数との比較もテストする
        }
        [TestMethod()]
        public void CompareToTest_正常系_演算子_大なり()
        {
#pragma warning disable CS1718 // 同じ変数との比較もテストする
            Assert.IsFalse(large > large);
            Assert.IsTrue(large > small);
            Assert.IsTrue(large > small2);

            Assert.IsFalse(small > large);
            Assert.IsFalse(small > small);
            Assert.IsFalse(small > small2);

            Assert.IsFalse(small2 > large);
            Assert.IsFalse(small2 > small);
            Assert.IsFalse(small2 > small2);
#pragma warning restore CS1718 // 同じ変数との比較もテストする
        }
        [TestMethod()]
        public void CompareToTest_正常系_演算子_小なりイコール()
        {
#pragma warning disable CS1718 // 同じ変数との比較もテストする
            Assert.IsTrue(large <= large);
            Assert.IsFalse(large <= small);
            Assert.IsFalse(large <= small2);

            Assert.IsTrue(small <= large);
            Assert.IsTrue(small <= small);
            Assert.IsTrue(small <= small2);

            Assert.IsTrue(small2 <= large);
            Assert.IsTrue(small2 <= small);
            Assert.IsTrue(small2 <= small2);
#pragma warning restore CS1718 // 同じ変数との比較もテストする
        }
        [TestMethod()]
        public void CompareToTest_正常系_演算子_大なりイコール()
        {
#pragma warning disable CS1718 // 同じ変数との比較もテストする
            Assert.IsTrue(large >= large);
            Assert.IsTrue(large >= small);
            Assert.IsTrue(large >= small2);

            Assert.IsFalse(small >= large);
            Assert.IsTrue(small >= small);
            Assert.IsTrue(small >= small2);

            Assert.IsFalse(small2 >= large);
            Assert.IsTrue(small2 >= small);
            Assert.IsTrue(small2 >= small2);
#pragma warning restore CS1718 // 同じ変数との比較もテストする
        }

        [TestMethod()]
        public void EqualsTest_正常系_同クラス()
        {
            Assert.IsTrue(large.Equals(large));
            Assert.IsFalse(large.Equals(small));
            Assert.IsFalse(large.Equals(small2));

            Assert.IsFalse(small.Equals(large));
            Assert.IsTrue(small.Equals(small));
            Assert.IsTrue(small.Equals(small2));

            Assert.IsFalse(small2.Equals(large));
            Assert.IsTrue(small2.Equals(small));
            Assert.IsTrue(small2.Equals(small2));
        }

        [TestMethod()]
        public void EqualsTest_正常系_オブジェクト()
        {
            object objSmall = new Hp(small.real);
            object objNotHp = new object();

            Assert.IsFalse(large.Equals(objSmall));
            Assert.IsTrue(small.Equals(objSmall));
            Assert.IsTrue(small2.Equals(objSmall));

            Assert.IsFalse(large.Equals(objNotHp));
            Assert.IsFalse(small.Equals(objNotHp));
            Assert.IsFalse(small2.Equals(objNotHp));
        }

        [TestMethod()]
        public void GetHashCodeTest_正常系()
        {
            Assert.AreEqual(large.GetHashCode(), large.GetHashCode());
            Assert.AreNotEqual(large.GetHashCode(), small.GetHashCode());
            Assert.AreNotEqual(large.GetHashCode(), small2.GetHashCode());

            Assert.AreEqual(small.GetHashCode(), small.GetHashCode());
            Assert.AreEqual(small.GetHashCode(), small2.GetHashCode());

            Assert.AreEqual(small2.GetHashCode(), small2.GetHashCode());
        }
    }
}