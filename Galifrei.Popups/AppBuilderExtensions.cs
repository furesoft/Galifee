using Galifrei.Core;
using Galifrei.Core.AppBuilder;
using Galifrei.Core.Controls;
using Galifrei.Core.I18N;
using Galifrei.Core.Loaders;
using System.ComponentModel;

namespace Galifrei.Popups
{
    public static class AppBuilderExtensions
    {
        public static ISetupAppBuilder EnableMessageOnClose(this ISetupAppBuilder builder)
        {
            //ToDo: implement enablemessage on close

            if (builder.Context.Properties[NamingConstants.Silent] == null)
            {
                builder.Context.Events.Add(EventConstants.WindowClose, (_) =>
                {
                    if (_ is CancelEventArgs e)
                    {
                        DialogService.Open(new CloseWindowPopup());
                        e.Cancel = true;
                    }
                });
            }
            else
            {
                //ToDo: Add switch for console
            }

            //ToDo: replace with automatic language resource loader
            LanguageManager.Instance.AppendLanguageAsync(builder.Context.Properties[NamingConstants.CurrentLanguageName].ToString(),
                new AssemblyResourceLoader("Galifrei.Popups.Resources." + builder.Context.Properties[NamingConstants.CurrentLanguageName] + ".json", typeof(AppBuilderExtensions).Assembly));

            return builder;
        }
    }
}