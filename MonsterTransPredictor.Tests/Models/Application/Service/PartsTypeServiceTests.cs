using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonsterTransPredictor.Models.Application.Value;
using System;

namespace MonsterTransPredictor.Models.Application.Service.Tests
{
    [TestClass()]
    public class PartsTypeServiceTests
    {
        [TestMethod()]
        public void ToNameTest_正常系()
        {
            Assert.AreEqual("頭部", PartsType.head.ToName());
            Assert.AreEqual("腕部", PartsType.arm.ToName());
            Assert.AreEqual("脚部", PartsType.leg.ToName());
            Assert.AreEqual("身体", PartsType.body.ToName());
            Assert.AreEqual("ブレス", PartsType.breath.ToName());
            Assert.AreEqual("魔法能力", PartsType.magic.ToName());
        }
        [TestMethod()]
        public void ToNameTest_異常系_外れ値()
        {
            var partsType = (PartsType)(-1);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => partsType.ToName());
        }
    }
}