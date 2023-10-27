using LegacyPrism.Test;
using Prism.Mvvm;

namespace LegacyPrism.ViewModule.MenuView
{
    internal class MenuViewModel : BindableBase
    {
        private readonly ITestInterface testInterface;

        public MenuViewModel(ITestInterface testInterface)
        {
            this.testInterface = testInterface;
        }
    }
}
