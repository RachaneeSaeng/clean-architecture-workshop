using CleanCodeApp.Domain.Entities;

namespace CleanCodeApp.Domain.Dependencies.Repositories;

public interface IShowTimeRepository
{
    void Save(ShowTime showTime);
}