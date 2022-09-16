using UnitOfShop.Models;

namespace UnitOfShop.Repositories;

public interface IOrderRepository
{
    void Save(Order order);
}