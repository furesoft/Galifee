﻿using System;

namespace Galifrei.Core.Platforming
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class PlatformImplementationAttribute : Attribute
    {
        public PlatformImplementationAttribute(OSName platform)
        {
            Platform = platform;
        }

        public OSName Platform { get; set; }
    }
}