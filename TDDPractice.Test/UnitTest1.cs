using Xunit;
using TDDPractice;

namespace TDDPractice.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var fizzbuzz = new Fizzbuzz();
            var actual = fizzbuzz.Convert(1);
            Assert.Equal(actual, "");
        }
    }
}
