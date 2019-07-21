using System.Collections.Generic;
using NUnit.Framework;

namespace BetweenTwoSets.Tests.SetLogic
{
    [TestFixture]
    public class SetLogicTests
    {
        private BetweenTwoSets.SetLogic _setLogic;

        [SetUp]
        public void SetUp()
        {
            _setLogic = new BetweenTwoSets.SetLogic();
        }

        [Test]
        public void GetTotalX_ValidLists_Returns2()
        {
            var a = new List<int> {2, 6};
            var b = new List<int> { 24, 36 };

            var result = _setLogic.GetTotalX(a, b);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void GetTotalX_InvalidLists_ThrowsException()
        {
            Assert.That(() => _setLogic.GetTotalX(null, null),Throws.ArgumentNullException);
        }
    }
}
