namespace Lesson5.Data;

public interface IOrderRepository
{
    Task<Order> GetById(Guid Id);
    Task<Order?> FindById(Guid Id);

    Task Add(Order order);
    Task Update(Order order);
}