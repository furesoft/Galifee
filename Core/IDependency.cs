namespace Galifree.Core
{
    public interface IDependency
    {
        public bool IsInstalled();

        public void Install(SetupContext context);
    }
}