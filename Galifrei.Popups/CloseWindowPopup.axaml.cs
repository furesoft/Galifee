using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Galifrei.Popups
{
    public class CloseWindowPopup : UserControl
    {
        public CloseWindowPopup()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
