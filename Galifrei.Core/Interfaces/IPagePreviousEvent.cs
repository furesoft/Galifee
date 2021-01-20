using System.Threading.Tasks;

namespace Galifrei.Core.Interfaces
{
    public interface IPagePreviousEvent
    {
        Task OnPrevious(SetupContext context);
    }
}