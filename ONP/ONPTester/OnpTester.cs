using System;
using Xunit;
using ONP;

namespace ONPTester
{
    public class OnpTester
    {
        private readonly Onp _onp;

        public OnpTester()
        {
            _onp = new Onp();
        }

        [Theory]
        [InlineData("(a+(b*c))", "abc*+")]
        [InlineData("((a+b)*(z+x))", "ab+zx+*")]
        [InlineData("((a+t)*((b+(a+c))^(c+d)))", "at+bac++cd+^*")]
        [InlineData("a+b", "ab+")]
        [InlineData("x+a*(b*c+d/e)", "xabc*de/+*+")]
        public void ConvertToOnpTest(string value, string expectedResult)
        {
            var result = _onp.ConvertToOnp(value);

            Assert.Equal(expectedResult, result);
        }
    }
}