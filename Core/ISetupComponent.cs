namespace Galifree.Core
{
    public interface ISetupComponent
    {
        void BeforeInstall(SetupContext context);

        void BeforeUninstall(SetupContext context);

        void AfterInstall(SetupContext context);

        void AfterUninstall(SetupContext context);
    }
}