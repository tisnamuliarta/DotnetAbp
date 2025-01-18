using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Sales.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
