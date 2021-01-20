using Galifrei.Core;
using Galifrei.Core.AppBuilder;
using Galifrei.Core.Controls;

namespace Galifrei.Popups
{
    public static class AppBuilderExtensions
    {
        public static ISetupAppBuilder EnableMessageOnClose(this ISetupAppBuilder builder)
        {
            //ToDo: implement enablemessage on close
            builder.Context.Events.Add(EventConstants.WindowClose, (_) =>
            {
                DialogService.Open(new Popups.CloseWindowPopup());
            });

            return builder;
        }
    }
}