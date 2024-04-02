using CleanCodeApp.Domain.Entities;
using CleanCodeApp.Presentation.DTOs;

namespace CleanCodeApp.Presentation.ObjectMappers;

public static class MovieMapper
{
    public static MovieDto ToDto(this Movie source)
    {
        return new MovieDto()
        {
            Id = source.Id,
            Title = source.Title,
            Description = source.Description,
            Length = source.Length
        };
    }
}


