using LegacyPrism.Test;

namespace LegacyPrism.ServiceModule.Test
{
    internal class TestService : ITestInterface
    {
        public string Greetings => "Hello from ServiceModule.TestService";
    }
}
