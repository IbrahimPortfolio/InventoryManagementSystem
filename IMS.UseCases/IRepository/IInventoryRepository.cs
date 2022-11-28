using IMS.CoreBusiness.Models;

namespace IMS.UseCases.IRepository
{
    public interface IInventoryRepository
    {
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
    }
}
