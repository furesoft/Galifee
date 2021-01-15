using Avalonia.Animation;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Galifrei.Core.I18N;
using System;
using System.Windows.Input;

namespace Galifrei.UI.Commands
{
    public class NextCommand : MarkupExtension, ICommand
    {
        public Button Target { get; }

        public event EventHandler CanExecuteChanged;

        public NextCommand(Button target)
        {
            Target = target;
        }

        public NextCommand()
        {
        }

        private bool _isFinished = false;

        public bool CanExecute(object parameter)
        {
            if (parameter is Carousel car)
            {
                var items = (AvaloniaList<object>)car.Items;

                //ToDo: need to rethink for better performance
                car.PropertyChanged += (s, e) =>
                {
                    if (e.Property.Name == nameof(car.SelectedIndex))
                    {
                        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                    }
                };

                if (car.SelectedIndex + 1 == items.Count)
                {
                    Target.Content = LanguageManager.Instance.GetValue("finish");

                    if (_isFinished)
                    {
                        ((IClassicDesktopStyleApplicationLifetime)App.Current.ApplicationLifetime).Shutdown();
                    }

                    _isFinished = true;

                    return true;
                }
            }

            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is Carousel car)
            {
                car.Next();
            }
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var ipv = (IProvideValueTarget)serviceProvider.GetService(typeof(IProvideValueTarget));

            return new NextCommand((Button)ipv.TargetObject);
        }
    }
}