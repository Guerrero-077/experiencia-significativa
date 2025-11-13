using AutoMapper;
using Entity.Context;
using Entity.Dtos.ModuleOperational;
using Entity.Models.ModuleOperation;
using Entity.Requests.ModuleOperation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Interfaces.IModuleOperationRepository;
using Utilities.Helper;
 



namespace Repository.Implementations.ModuleOperationRepository
{
    public class ExperienceRepository : BaseModelRepository<Experience, ExperienceDTO, ExperienceRequest>, IExperienceRepository
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        private readonly IHelper<Experience, ExperienceDTO> _helperRepository;

        public ExperienceRepository(ApplicationContext context, IMapper mapper, IHelper<Experience, ExperienceDTO> helperRepository, IConfiguration configuration) : base(context, mapper, configuration, helperRepository)
        {
            _context = context;
            _mapper = mapper;
            _helperRepository = helperRepository;
            _configuration = configuration;
        }


        public async Task<Experience> AddAsync(Experience experience)
        {
            _context.Experiences.Add(experience);
            await _context.SaveChangesAsync();
            return experience;
        }


        public async Task<Experience?> GetByIdWithDetailsAsync(int id)
        {
            return await _context.Experiences
                 .Include(e => e.Leaders)
                .Include(e => e.Institution)
                .Include(e => e.Documents)
                .Include(e => e.User)
                .ThenInclude(u => u.Person)
                .Include(e => e.Evaluations)
                .ThenInclude(ev => ev.EvaluationCriterias)
                .ThenInclude(ec => ec.Criteria)
                .Include(e => e.Institution)
                .ThenInclude(i => i.Departaments)
                .Include(e => e.Institution)
                .ThenInclude(i => i.Municipalitis)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

      



        public async Task UpdateAsync(Experience experience)
        {
            _context.Experiences.Update(experience);
            await _context.SaveChangesAsync();
        }



        public async Task<Experience?> GetByIdAsync(int id)
        {
            return await _context.Experiences
                .FirstOrDefaultAsync(e => e.Id == id);
        }



        public async Task<IEnumerable<Experience>> GetAllAsync()
        {
            return await _context.Experiences.ToListAsync();
        }



        public async Task<IEnumerable<Experience>> GetByUserIdAsync(int userId)
        {
            return await _context.Experiences
                .Where(e => e.UserId == userId)
                .ToListAsync();
        }


    }
}
