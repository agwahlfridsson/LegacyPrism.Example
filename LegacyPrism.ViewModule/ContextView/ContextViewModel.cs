using LegacyPrism.Test;
using Prism.Mvvm;

namespace LegacyPrism.ViewModule.ContextView
{
    internal class ContextViewModel : BindableBase
    {
        private readonly ITestInterface testService;

        public ContextViewModel(ITestInterface testService)
        {
            this.testService = testService;
        }
    }
}
