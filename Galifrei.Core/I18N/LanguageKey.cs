﻿using Avalonia.Markup.Xaml;
using System;

namespace Galifrei.Core.I18N
{
    public class LanguageKey : MarkupExtension
    {
        public LanguageKey(string key)
        {
            Key = key;
        }

        public string Key { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return LanguageManager.Instance.GetValue(Key);
        }
    }
}