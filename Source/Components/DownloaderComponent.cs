﻿using Avalonia.Controls;
using GaliFee.Core;
using GaliFee.Core.Interfaces;
using System.Threading.Tasks;

namespace Galifee.Components
{
    public class DownloaderComponent : ISetupComponent, IVisualComponent
    {
        public string Filename { get; set; }

        public Control GetVisualControl(SetupContext context)
        {
            return new UI.DownloaderUIPanel(this);
        }

        public Task OnInstall(SetupContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task OnUninstall(SetupContext context)
        {
            throw new System.NotImplementedException();
        }

        public Task OnUpgrade(SetupContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}