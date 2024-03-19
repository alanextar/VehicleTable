using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using VehicleTable.Server;

namespace VehicleTable
{
    [ApiController]
    [Route("[controller]")]
    public class VehiclesController : Controller
    {
        private readonly ApplicationContext _context;

        public VehiclesController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<LoadResult> Get(DataSourceLoadOptions loadOptions)
        {
            var vehicles = _context.Vehicles.AsNoTracking().Select(vehicle => new VehicleDto
            {
                CId = vehicle.CId,
                CTitle = vehicle.CTitle,
                CSalerName = vehicle.CSalerName,
                COriginDate = vehicle.COriginDate,
                CDescription = vehicle.CDescription != null && vehicle.CDescription.Length > 250 ?
                                            (vehicle.CDescription.Substring(250) + "...") : 
                                            vehicle.CDescription,
            });
            var result = await DataSourceLoader.LoadAsync(vehicles, loadOptions);

            return result;
        }
    }
}
