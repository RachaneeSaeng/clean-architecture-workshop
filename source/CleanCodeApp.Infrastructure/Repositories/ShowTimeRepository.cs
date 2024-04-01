using CleanCodeApp.Domain.Dependencies.Repositories;
using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Infrastructure.Repositories;

public class ShowTimeRepository : IShowTimeRepository
{
    private static readonly List<ShowTime> ShowTimes = [];

    public void Save(ShowTime showTime)
    {
        ShowTimes.Add(showTime);
    }
}