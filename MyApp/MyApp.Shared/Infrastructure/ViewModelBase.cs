using Microsoft.Practices.Prism.Mvvm;

namespace MyApp.Infrastructure
{
#if NETFX_CORE
    public abstract partial class ViewModelBase : ViewModel
#else
    public abstract partial class ViewModelBase : BindableBase
#endif
    {
    }
}
