using Microsoft.Practices.Prism.Mvvm;

namespace MyApp.Infrastructure
{
#if NETFX_CORE
    public abstract partial class PageBase : Windows.UI.Xaml.Controls.Page, IView
#else
    public abstract partial class PageBase : System.Windows.Controls.Page, IView
#endif
    {
    }
}
