using Microsoft.CSharp.RuntimeBinder;

namespace Test14C.Tests.NUnit
{
    public class Tests
    {
        [TestFixture]
        public class MatekTests
        {
            #region Ne figyelj erre!
            [SetUp, TearDown] public static void DoNothing() { }
            #endregion

            [Test]
            [TestCase(5, 3, 2)]
            [TestCase(-2.5, 1.5, -4.0)]
            [TestCase(0, 0, 0)]
            public void Kivonas(double a, double b, double o)
            {
                Assert.That(o, Is.EqualTo(Szamol.Kivonas(a, b)));
            }

            [Test]
            [TestCase(5, 3, false)]
            [TestCase(-2.5, 1.5, false)]
            [TestCase(123, "macska", true)]
            public void KivonasDob(dynamic a, dynamic b, bool o)
            {
                if (o)
                {
                    Assert.Throws<RuntimeBinderException>(Act);
                }
                else
                {
                    Act();
                }

                return;

                void Act() => Szamol.Kivonas(a, b);
            }

            [Test]
            [TestCase(2, 3, 6)]
            [TestCase(-1.5, 4, -6.0)]
            [TestCase(0, 7.5, 0)]
            public void Szorzas(double a, double b, double o)
            {
                Assert.That(o, Is.EqualTo(Szamol.Szorzas(a, b)));
            }

            [Test]
            [TestCase(2, 3, false)]
            [TestCase(-1.5, 4, false)]
            [TestCase(0, "macska", true)]
            public void SzorzasDob(dynamic a, dynamic b, bool o)
            {
                if (o)
                {
                    Assert.Throws<RuntimeBinderException>(Act);
                }
                else
                {
                    Act();
                }

                return;

                void Act() => Szamol.Szorzas(a, b);
            }

            [Test]
            [TestCase(9, 3)]
            [TestCase(16, 4)]
            [TestCase(2.25, 1.5)]
            public void Gyok(double a, double o)
            {
                Assert.That(o, Is.EqualTo(Szamol.Gyok(a)));
            }

            [Test]
            [TestCase(9, false)]
            [TestCase("macska", true)]
            [TestCase(2.25, false)]
            public void GyokDob(dynamic a, bool o)
            {
                if (o)
                {
                    Assert.Throws<RuntimeBinderException>(Act);
                }
                else
                {
                    Act();
                }

                return;

                void Act() => Szamol.Gyok(a);
            }

            [Test]
            [TestCase(3, 4, 5, true)]
            [TestCase(1, 1, 3, false)]
            [TestCase(6, 8, 15, false)]
            public void SzerkezhetoE(int a, int b, int c, bool o)
            {
                Assert.That(o, Is.EqualTo(Szamol.SzerkezhetoE(a, b, c)));
            }
        }
    }
}