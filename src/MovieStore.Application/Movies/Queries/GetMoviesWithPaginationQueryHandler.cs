using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using MovieStore.Application.Common.Interfaces;
using MovieStore.Application.Common.Mappings;
using MovieStore.Application.Common.Models;

namespace MovieStore.Application.Movies.Queries;

public class GetMoviesWithPaginationQueryHandler : IRequestHandler<GetMoviesWithPaginationQuery, PaginatedList<MovieDTO>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetMoviesWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<MovieDTO>> Handle(GetMoviesWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await _context.Movies
            .OrderBy(x => x.Title)
            .ProjectTo<MovieDTO>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
