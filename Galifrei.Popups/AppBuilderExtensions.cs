using Galifrei.Core;
using Galifrei.Core.AppBuilder;
using Galifrei.Core.Controls;
using System.ComponentModel;

namespace Galifrei.Popups
{
    public static class AppBuilderExtensions
    {
        public static ISetupAppBuilder EnableMessageOnClose(this ISetupAppBuilder builder)
        {
            //ToDo: implement enablemessage on close
            builder.Context.Events.Add(EventConstants.WindowClose, (_) =>
            {
                if (_ is CancelEventArgs e)
                {
                    DialogService.Open(new Popups.CloseWindowPopup());
                    e.Cancel = true;
                }
            });

            return builder;
        }
    }
}