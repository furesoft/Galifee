using Avalonia.Animation;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Galifee.Core.I18N;
using System;
using System.Windows.Input;

namespace Galifee.UI.Commands
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

        public bool CanExecute(object parameter)
        {
            if (parameter is Carousel car)
            {
                var items = (AvaloniaList<object>)car.Items;

                if (car.SelectedIndex + 1 == items.Count)
                {
                    car.PropertyChanged += (s, e) =>
                    {
                        if (e.Property.Name == nameof(car.SelectedIndex))
                        {
                            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                        }
                    };

                    Target.Content = LanguageManager.Instance.GetValue("finish");

                    return false;
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