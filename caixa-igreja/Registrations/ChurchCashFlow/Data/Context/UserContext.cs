using AutoMapper;
using ChurchCashFlow.Data.Queries;
using ChurchCashFlow.Data.ViewModels;
using ChurchCashFlow.Data.ViewModels.Dtos.User;

namespace ChurchCashFlow.Data.Context
{
    public class UserContext 
    {
        private ModelContext _context;
        private IMapper _mapper;

        public UserContext(ModelContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ReadUserDto> GetAll(bool active)
        {
            try
            {
                var userExpression = UsersQueries.GetUsersActive(active);

                var usersQueryable = _context.Users.
                    Include(x => x.Church).Include(x => x.Role).AsNoTracking().AsQueryable();

                var users = usersQueryable.Where(userExpression);

                IEnumerable<ReadUserDto> usersReadDto = _mapper.Map<IEnumerable<ReadUserDto>>(users);

                return Ok(new ResultViewModel<IEnumerable<ReadUserDto>>(usersReadDto));
            }
            catch
            {
                return StatusCode(500, new ResultViewModel<string>("Internal Error - US1101A"));
            }

            return null;
        }

        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
