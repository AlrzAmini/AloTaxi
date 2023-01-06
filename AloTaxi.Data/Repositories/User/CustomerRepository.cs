using AloTaxi.Data.Context;
using AloTaxi.Domain.Entities.User;
using AloTaxi.Domain.Interfaces;
using AloTaxi.Domain.Interfaces.User;
namespace AloTaxi.Data.Repositories.User;

public class CustomerRepository : ICustomerRepository
{
   private readonly AloTaxiDbContext _context;
   private readonly IUserGenericRepository<Customer> _customerGenericRepository;

   public CustomerRepository(AloTaxiDbContext context, IUserGenericRepository<Customer> customerGenericRepository)
   {
       _context = context;
       _customerGenericRepository = customerGenericRepository;
   }
}