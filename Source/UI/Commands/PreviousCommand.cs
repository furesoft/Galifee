using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Windows.Input;

namespace Galifrei.UI.Commands
{
    public class PreviousCommand : MarkupExtension, ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (parameter is Carousel car)
            {
                if (car.SelectedIndex == 0)
                {
                    car.PropertyChanged += (s, e) =>
                      {
                          if (e.Property.Name == nameof(car.SelectedIndex))
                          {
                              CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                          }
                      };

                    return false;
                }
            }

            //CanExecuteChanged?.Invoke(this, EventArgs.Empty);

            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is Carousel car)
            {
                car.Previous();
            }
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new PreviousCommand();
        }
    }
}