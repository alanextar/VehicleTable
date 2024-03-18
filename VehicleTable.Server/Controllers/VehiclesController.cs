using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using VehicleTable.Server;

namespace VehicleTable
{
    public class VehiclesController : Controller
    {
        private readonly ApplicationContext _context;

        public VehiclesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("vehicles")]

        public async Task<LoadResult> Get(DataSourceLoadOptions loadOptions)
        {
            var vehicles = _context.Vehicles.AsNoTracking();
            var result = await DataSourceLoader.LoadAsync(vehicles, loadOptions);

            return result;
        }
    }
}
