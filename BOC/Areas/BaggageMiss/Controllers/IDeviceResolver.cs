using Catel.Services;

namespace BOC.Areas.BaggageMiss.Controllers
{
    public interface IDeviceResolver
    {
        IService Device { get; set; }
    }
}