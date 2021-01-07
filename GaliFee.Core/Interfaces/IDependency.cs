﻿namespace Galifee.Core.Interfaces
{
    public interface IDependency
    {
        public bool IsInstalled();

        public void Install(SetupContext context);
    }
}