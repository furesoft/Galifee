using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;
using System.Windows.Input;

namespace Galifee.UI.Commands
{
    public class NextCommand : MarkupExtension, ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //ToDo: implement condition for next button

            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is Carousel car)
            {
                car.PageTransition = new PageSlide(TimeSpan.FromMilliseconds(400));
                car.Next();
            }
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return new NextCommand();
        }
    }
}