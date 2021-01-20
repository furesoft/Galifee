using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Galifrei.Core.I18N;
using System;
using System.Windows.Input;

namespace Galifrei.UI.Commands
{
    public class SetLanguageCommand : MarkupExtension, ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ComboBox cb)
            {
                LanguageManager.Instance.SetLanguageFromName(cb.SelectedItem.ToString());
                var lifetime = (IClassicDesktopStyleApplicationLifetime)App.Current.ApplicationLifetime;

                var mw = new MainWindow();

                mw.Show();

                lifetime.MainWindow.Close();
                lifetime.MainWindow = mw;
            }
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new SetLanguageCommand();
        }
    }
}