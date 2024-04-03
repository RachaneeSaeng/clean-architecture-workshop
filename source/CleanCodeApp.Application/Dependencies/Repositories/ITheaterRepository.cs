using CleanCodeApp.Domain.ValueObjects;

namespace CleanCodeApp.Domain.Dependencies.Repositories;

public interface ITheaterRepository
{
    public Theater GetByName(string name);
}