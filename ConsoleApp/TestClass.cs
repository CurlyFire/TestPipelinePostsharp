using Aspects;

namespace ConsoleApp
{

    public class TestClass
    {
        [Throws]
        public int DoSomething()
        {
            return 3;
        }

    }
}
