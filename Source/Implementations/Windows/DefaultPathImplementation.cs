﻿using Galifee.Core.Interfaces;
using Galifee.Core.Platforming;
using System;

namespace Galifee.Components.OsSpecific.Windows
{
    [PlatformImplementation(OSName.Windows)]
    public class DefaultPathImplementation : IDefaultPaths
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

        public string DefaultLinkExtension => ".lnk";
    }
}