using autofac_example;
using NUnit.Framework;

namespace tests
{
    public class Test
    {
        [Test]
        public void Call_things()
        {
            var program = new Program();
            program.Go();
        }
    }
}
