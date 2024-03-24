using AutoMapper;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Data.ResponseModel;
using Microsoft.AspNetCore.Mvc;
using VehicleTable.Server;

namespace VehicleTable
{
    [ApiController]
    [Route("[controller]")]
    public class VehiclesController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IMapper mapper;

        public VehiclesController(ApplicationContext context, IMapper mapper)
        {
            _context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<LoadResult> Get(DataSourceLoadOptions loadOptions)
        {
            var vehicles = mapper.ProjectTo<VehicleDto>(_context.Vehicles, null);
            var result = await DataSourceLoader.LoadAsync(vehicles, loadOptions);

            return result;
        }
    }
}
