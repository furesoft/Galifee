using System.Threading.Tasks;

namespace Galifee.Core.Interfaces
{

    public interface IPagePreviousEvent
    {
        Task OnPrevious(SetupContext context);
    }
}