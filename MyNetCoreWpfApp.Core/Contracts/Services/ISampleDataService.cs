using System.Collections.Generic;
using System.Threading.Tasks;

using MyNetCoreWpfApp.Core.Models;

namespace MyNetCoreWpfApp.Core.Contracts.Services
{
    public interface ISampleDataService
    {
        Task<IEnumerable<SampleOrder>> GetContentGridDataAsync();

        Task<IEnumerable<SampleOrder>> GetGridDataAsync();

        Task<IEnumerable<SampleOrder>> GetMasterDetailDataAsync();
    }
}
