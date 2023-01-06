using AloTaxi.Domain.Entities.Log;

namespace AloTaxi.Domain.Interfaces.Log;

public interface ILoggerRepository
{
    public Task LogInformation(LogModel model);
}