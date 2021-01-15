using System.Threading.Tasks;

namespace Galifrei.Core.Interfaces
{
    public interface IPageNextEvent
    {
        Task OnNext(SetupContext context);
    }
}