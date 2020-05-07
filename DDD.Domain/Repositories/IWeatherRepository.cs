using DDD.Domain.Entities;

namespace DDD.Domain.Repositories
{
    public interface IWeatherRepository
    {
        WheatherEntity  GetLatest(int areaId);
    }
}
