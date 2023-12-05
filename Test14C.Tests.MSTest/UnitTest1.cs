using Microsoft.CSharp.RuntimeBinder;

namespace Test14C.Tests.MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class MatekTests
        {
            [TestMethod]
            [DataRow(5, 3, 2)]
            [DataRow(-2.5, 1.5, -4.0)]
            [DataRow(0, 0, 0)]
            public void Kivonas(double a, double b, double o)
            {
                Assert.AreEqual(o, Szamol.Kivonas(a, b));
            }

            [TestMethod]
            [DataRow(5, 3, false)]
            [DataRow(-2.5, 1.5, false)]
            [DataRow(123, "macska", true)]
            public void KivonasDob(dynamic a, dynamic b, bool o)
            {
                if (o)
                {
                    Assert.ThrowsException<RuntimeBinderException>(Act);
                }
                else
                {
                    Act();
                }

                return;

                void Act() => Szamol.Kivonas(a, b);
            }

            [TestMethod]
            [DataRow(2, 3, 6)]
            [DataRow(-1.5, 4, -6.0)]
            [DataRow(0, 7.5, 0)]
            public void Szorzas(double a, double b, double o)
            {
                Assert.AreEqual(o, Szamol.Szorzas(a, b));
            }

            [TestMethod]
            [DataRow(2, 3, false)]
            [DataRow(-1.5, 4, false)]
            [DataRow(0, "macska", true)]
            public void SzorzasDob(dynamic a, dynamic b, bool o)
            {
                if (o)
                {
                    Assert.ThrowsException<RuntimeBinderException>(Act);
                }
                else
                {
                    Act();
                }

                return;

                void Act() => Szamol.Szorzas(a, b);
            }

            [TestMethod]
            [DataRow(9, 3)]
            [DataRow(16, 4)]
            [DataRow(2.25, 1.5)]
            public void Gyok(double a, double o)
            {
                Assert.AreEqual(o, Szamol.Gyok(a));
            }

            [TestMethod]
            [DataRow(9, false)]
            [DataRow("macska", true)]
            [DataRow(2.25, false)]
            public void GyokDob(dynamic a, bool o)
            {
                if (o)
                {
                    Assert.ThrowsException<RuntimeBinderException>(Act);
                }
                else
                {
                    Act();
                }

                return;

                void Act() => Szamol.Gyok(a);
            }

            [TestMethod]
            [DataRow(3, 4, 5, true)]
            [DataRow(1, 1, 3, false)]
            [DataRow(6, 8, 15, false)]
            public void SzerkezhetoE(int a, int b, int c, bool o)
            {
                Assert.AreEqual(o, Szamol.SzerkezhetoE(a, b, c));
            }
        }
    }
}