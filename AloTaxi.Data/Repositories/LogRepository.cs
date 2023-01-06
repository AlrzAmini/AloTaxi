using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AloTaxi.Data.Context;
using AloTaxi.Domain.Entities.Log;
using AloTaxi.Domain.Interfaces.Log;

namespace AloTaxi.Data.Repositories
{
    public class LogRepository : ILoggerRepository
    {
        private readonly AloTaxiDbContext _context;

        public LogRepository(AloTaxiDbContext context)
        {
            _context = context;
        }

        public async Task LogInformation(LogModel model)
        {
            await _context.Logs.AddAsync(model);
        }
    }
}
