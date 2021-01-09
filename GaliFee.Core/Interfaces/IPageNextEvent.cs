using System.Threading.Tasks;

namespace Galifee.Core.Interfaces
{
    public interface IPageNextEvent
    {
        Task OnNext(SetupContext context);
    }
}