using BSRMWPFUserInterface.ViewModels;
using Caliburn.Micro;
using System.Windows;

namespace BSRMWPFUserInterface
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
