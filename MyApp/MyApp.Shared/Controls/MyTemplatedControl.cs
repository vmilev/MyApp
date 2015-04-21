#if WPF
using System.Windows;
using System.Windows.Controls;
#endif

#if NETFX_CORE
using Windows.UI.Xaml.Controls;
#endif

namespace MyApp.Controls
{
    public sealed class MyTemplatedControl : Control
    {
        public MyTemplatedControl()
        {
#if NETFX_CORE
            this.DefaultStyleKey = typeof(MyTemplatedControl);
#endif
        }

#if WPF
        static MyTemplatedControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyTemplatedControl), new FrameworkPropertyMetadata(typeof(MyTemplatedControl)));
        }
#endif
    }
}
