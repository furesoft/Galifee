using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace Galifrei
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            this.Activated += MainWindow_Activated;
            this.Closing += MainWindow_Closing;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Runtime.Context.Events.Invoke(Core.EventConstants.WindowClose, e);
        }

        private void MainWindow_Activated(object sender, System.EventArgs e)
        {
            var carousel = this.Find<Carousel>("carousel");

            carousel.PageTransition = new PageSlide(TimeSpan.FromMilliseconds(150));
        }
    }
}