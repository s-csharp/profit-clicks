using NUnit.Framework;
using ProfitClicksHelpers.Helpers;
using System;

namespace ProfitClicksTests.Helpers
{
    [TestFixture]
    public class ArrayHelpersTest
    {
        private readonly int[] _sampleArray = new[] { 7, -1, 1, -7, 0, -4, 3, 2, -5, -6, 8 };

        #region ExistNumbersAsSum

        [Test]
        public void SuccessExistNumbersAsSum()
        {
            Assert.True(ArrayHelper.ExistNumbersAsSum(_sampleArray, 5));
        }

        [Test]
        public void FailExistNumbersAsSum()
        {
            Assert.False(ArrayHelper.ExistNumbersAsSum(_sampleArray, 20));
        }

        [Test]
        public void EmptyOrNullArrayExistNumbersAsSum()
        {
            Assert.Throws<ArgumentNullException>(delegate { ArrayHelper.ExistNumbersAsSum(null, 5); });
            Assert.Throws<ArgumentNullException>(delegate { ArrayHelper.ExistNumbersAsSum(new int[0], 5); });
        }

        #endregion

        #region MaxPrefix

        [Test]
        public void EmptyMaxPrefix()
        {
            var array = new[] { "qwe", "qweasd", "qwsdfsdf", "tr" };

            Assert.AreEqual("", ArrayHelper.MaxPrefix(array));
        }

        [Test]
        public void EmptyWithEmptyMaxPrefix()
        {
            var array = new[] { "qwe", "qweasd", "qwsdfsdf", "" };

            Assert.AreEqual("", ArrayHelper.MaxPrefix(array));
        }

        [Test]
        public void EmptyWithNullMaxPrefix()
        {
            var array = new[] { "qwe", "qweasd", "qwsdfsdf", null };

            Assert.AreEqual("", ArrayHelper.MaxPrefix(array));
        }

        [Test]
        public void OneLengthMaxPrefix()
        {
            var array = new[] { "qwe", "qeasd", "qwsdfsdf" };

            Assert.AreEqual("q", ArrayHelper.MaxPrefix(array));
        }

        [Test]
        public void TwoLengthMaxPrefix()
        {
            var array = new[] { "qwe", "qweasd", "qwsdfsdf" };

            Assert.AreEqual("qw", ArrayHelper.MaxPrefix(array));
        }

        [Test]
        public void EmptyOrNullArrayMaxPrefix()
        {
            Assert.Throws<ArgumentNullException>(delegate { ArrayHelper.MaxPrefix(null); });
            Assert.Throws<ArgumentNullException>(delegate { ArrayHelper.MaxPrefix(new string[0]); });
        }

        #endregion
    }
}