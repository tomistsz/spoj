using System;
using Xunit;
using NSTEPS;

namespace NSTEPS.Tester
{
    public class NstepsTester
    {
        private readonly Nsteps _nsteps;

        public NstepsTester()
        {
            _nsteps = new Nsteps();
        }

        [Theory]
        [InlineData(0, 0, "0")]
        [InlineData(1, 1, "1")]
        [InlineData(2, 0, "2")]
        [InlineData(3, 1, "3")]
        [InlineData(2, 2, "4")]
        [InlineData(3, 3, "5")]
        [InlineData(4, 2, "6")]
        [InlineData(5, 3, "7")]
        [InlineData(4, 4, "8")]
        [InlineData(5, 5, "9")]
        [InlineData(6, 4, "10")]
        [InlineData(7, 5, "11")]
        [InlineData(6, 6, "12")]
        [InlineData(1, 0, "No Number")]
        [InlineData(0, 1, "No Number")]
        [InlineData(4, 1, "No Number")]
        [InlineData(4, 3, "No Number")]
        [InlineData(4, 5, "No Number")]
        public void SolveNstepsProblemTester(int x, int y, string expectedResult)
        {
            var result = _nsteps.SolveNstepsProblem(x, y);

            Assert.Equal(expectedResult, result);
        }

    }
}