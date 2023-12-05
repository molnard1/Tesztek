using FluentAssertions;
using Microsoft.CSharp.RuntimeBinder;

namespace Test14C.Tests
{
    public class MatekTests
    {
        [Theory]
        [InlineData(5,3,2)]
        [InlineData(-2.5, 1.5, -4.0)]
        [InlineData(0,0,0)]
        public void Kivonas(double a, double b, double o)
        {
            Szamol.Kivonas(a, b).Should().Be(o);
        }

        [Theory]
        [InlineData(5,3,false)]
        [InlineData(-2.5, 1.5, false)]
        [InlineData(123,"macska", true)]
        public void KivonasDob(dynamic a, dynamic b, bool o)
        {
            Action act = () => Szamol.Kivonas(a, b);
            if (o)
            {
                act.Should().Throw<RuntimeBinderException>();
            }
            else
            {
                act.Should().NotThrow();
            }
        }

        [Theory]
        [InlineData(2,3,6)]
        [InlineData(-1.5, 4, -6.0)]
        [InlineData(0, 7.5, 0)]
        public void Szorzas(double a, double b, double o)
        {
            Szamol.Szorzas(a, b).Should().Be(o);
        }

        [Theory]
        [InlineData(2,3,false)]
        [InlineData(-1.5, 4, false)]
        [InlineData(0, "macska", true)]
        public void SzorzasDob(dynamic a, dynamic b, bool o)
        {
            Action act = () => Szamol.Szorzas(a, b);
            if (o)
            {
                act.Should().Throw<RuntimeBinderException>();
            }
            else
            {
                act.Should().NotThrow();
            }
        }

        [Theory]
        [InlineData(9,3)]
        [InlineData(16,4)]
        [InlineData(2.25, 1.5)]
        public void Gyok(double a, double o)
        {
            Szamol.Gyok(a).Should().Be(o);
        }

        [Theory]
        [InlineData(9,false)]
        [InlineData("macska",true)]
        [InlineData(2.25, false)]
        public void GyokDob(dynamic a, bool o)
        {
            Action act = () => Szamol.Gyok(a);
            if (o)
            {
                act.Should().Throw<RuntimeBinderException>();
            }
            else
            {
                act.Should().NotThrow();
            }
        }

        [Theory]
        [InlineData(3,4,5,true)]
        [InlineData(1,1,3,false)]
        [InlineData(6,8,15,false)]
        public void SzerkezhetoE(int a, int b, int c, bool o)
        {
            Szamol.SzerkezhetoE(a, b, c).Should().Be(o);
        }
    }
}