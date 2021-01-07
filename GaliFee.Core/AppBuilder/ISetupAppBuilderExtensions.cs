﻿using GaliFee.Core.I18N;
using GaliFee.Core.Interfaces;

namespace GaliFee.Core.AppBuilder
{
    public static class ISetupAppBuilderExtensions
    {
        public static ISetupAppBuilder SetProperty(this ISetupAppBuilder builder, string key, object value)
        {
            builder.Context.Properties.SetProperty(key, value);

            return builder;
        }

        public static ISetupAppBuilder AddComponent(this ISetupAppBuilder builder, IVisualComponent component)
        {
            builder.Context.Components.RegisterComponent(component);

            return builder;
        }

        public static ISetupAppBuilder AddAction(this ISetupAppBuilder builder, ISetupComponent component)
        {
            builder.Context.Pipeline.Add(component);

            return builder;
        }

        public static ISetupAppBuilder AddResource(this ISetupAppBuilder builder, IResourceLoader loader)
        {
            builder.Context.ResourceLoaders.RegisterResource(loader);

            return builder;
        }

        public static ISetupAppBuilder SetLanguage(this ISetupAppBuilder builder, string id)
        {
            LanguageManager.Instance.SetLanguage(id);
            builder.SetProperty(NamingConstants.CurrentLanguageName, id);

            return builder;
        }

        public static ISetupAppBuilder RegisterLanguage(this ISetupAppBuilder builder, string id, IResourceLoader loader)
        {
            LanguageManager.Instance.RegisterLanguage(id, loader);

            return builder;
        }
    }
}