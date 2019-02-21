using System;
using Xunit;
using ACPC10A;

namespace ACPC10A.Tester
{
    public class ACPC10ATester
    {
        private readonly ACPC10A _acpc10a;

        public ACPC10ATester()
        {
            _acpc10a = new ACPC10A();
        }


        [Theory]
        [InlineData(4, 7, 10, "AP 13")]
        [InlineData(2, 6, 18, "GP 54")]
        public void SolveAcpc10aTester(int a, int b, int c, string expectedResult)
        {
            var result = _acpc10a.SolveAcpc10a(a, b, c);

            Assert.Equal(expectedResult, result);
        }
    }
}
