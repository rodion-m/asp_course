using Microsoft.EntityFrameworkCore;

namespace Lesson5.Data;

class OrderRepository : IOrderRepository
{
    private readonly AppDbContext _dbContext;

    public OrderRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public Task<Order> GetById(Guid Id) 
        => _dbContext.Orders.FirstAsync(it => it.Id == Id);

    public Task<Order?> FindById(Guid Id) 
        => _dbContext.Orders.FirstOrDefaultAsync(it => it.Id == Id);

    public async Task Add(Order order)
    {
        await _dbContext.Orders.AddAsync(order);
        await _dbContext.SaveChangesAsync();
    }

    public async Task Update(Order order)
    {
        _dbContext.Entry(order).State = EntityState.Modified;
        await _dbContext.SaveChangesAsync();
    }
}