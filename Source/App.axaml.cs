using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Galifrei.Core;
using Galifrei.Core.I18N;
using Galifrei.UI.Windows;
using System.Linq;

namespace Galifrei
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                if (LanguageManager.Instance.GetNames().Count() > 1 && !Runtime.Context.Properties.GetProperty<bool>(NamingConstants.UseAutomaticLanguage))
                {
                    desktop.MainWindow = new LanguageSelectorWindow();
                }
                else
                {
                    desktop.MainWindow = new MainWindow();
                }

                desktop.Exit += (s, _) =>
                {
                    Runtime.Context.Events.Invoke(EventConstants.ApplicationClose, _.ApplicationExitCode);
                };

                desktop.ShutdownMode = Avalonia.Controls.ShutdownMode.OnLastWindowClose;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}