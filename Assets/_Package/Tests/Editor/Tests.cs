using System.Collections;
using NUnit.Framework;
using UnityEngine.TestTools;

namespace _Package.Tests.Editor
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestIsTrue()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void TestIsFalse()
        {
            Assert.IsFalse(false);
        }

        [UnityTest]
        public IEnumerator UnityTestIsTrue()
        {
            yield return null;

            Assert.IsTrue(true);
        }

        [UnityTest]
        public IEnumerator UnityTestIsFalse()
        {
            yield return null;

            Assert.IsFalse(false);
        }
    }
}
