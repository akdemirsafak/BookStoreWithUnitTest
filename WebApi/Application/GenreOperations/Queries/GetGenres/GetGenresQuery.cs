using AutoMapper;
using WebApi.DbOperations;

namespace WebApi.Application.GenreOperations.Queries.GetGenres
{
    public class GetGenresQuery
    {
        
        private readonly IBookStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetGenresQuery(IBookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<GenresViewModel> Handle()
        {
            var genres=_context.Genres.Where(x=>x.IsActivate).ToList();
            List<GenresViewModel> returnObj=_mapper.Map<List<GenresViewModel>>(genres);
            return returnObj;
        }


    }

    public class GenresViewModel{
        
        public string Name { get; set; }
    }
}