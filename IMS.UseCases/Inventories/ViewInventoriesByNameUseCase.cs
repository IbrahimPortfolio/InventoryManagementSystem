using IMS.CoreBusiness.Models;
using IMS.UseCases.Inventories.Interfaces;
using IMS.UseCases.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class ViewInventoriesByNameUseCase : IViewInventoriesByNameUseCase
    {
        private readonly IInventoryRepository _invetoryRepository;

        public ViewInventoriesByNameUseCase(IInventoryRepository invetoryRepository)
        {
            _invetoryRepository = invetoryRepository;
        }
        public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
        {
            var invetory = await _invetoryRepository.GetInventoriesByNameAsync(name);
            return invetory;
        }
    }


}
