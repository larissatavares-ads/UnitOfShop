using UnitOfShop.Models;

namespace UnitOfShop.Repositories;

public interface ICustomerRepository
{
    void Save(Customer customer);
}