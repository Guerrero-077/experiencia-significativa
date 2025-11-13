using Entity.Dtos.ModuleGeographic;
using Entity.Models.ModuleGeographic;
using Entity.Requests.ModuleGeographic;

namespace Repository.Interfaces.IModuleGeographicRepository
{
    public interface ICommuneRepository : IBaseModelRepository<Commune,CommuneDTO, CommuneRequest>
    {
    }
}
