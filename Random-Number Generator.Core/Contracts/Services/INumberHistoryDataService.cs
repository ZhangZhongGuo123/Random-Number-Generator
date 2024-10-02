using Random_Number_Generator.Core.Models;

namespace Random_Number_Generator.Core.Contracts.Services;

// Remove this class once your pages/features are using your data.
public interface INumberHistoryDataService
{
    Task<IEnumerable<NumberHistory>> GetGridDataAsync();
}