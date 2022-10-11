using TicketDb;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace TicketRepository;

public abstract class RepositoryEntity<T> : IRepositoryEntity<T> where T : class
{
    private readonly TicketContext _db;

    public RepositoryEntity(TicketContext db)
    {
        _db = db;
    }

    public T Create(T entity)
    {
        _db.Set<T>().Add(entity);
        return entity;
    }

    public virtual T GetById(int id)
    {
        return _db.Set<T>().Find(id);
    }

    public virtual List<T> List()
    {
        return _db.Set<T>().ToList();
    }

    public virtual List<T> ListByCondition(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
    {
        return _db.Set<T>()
                .Where(predicate)
                .ToList();
    }

    public void Update(T entity)
    {
        _db.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(T entity)
    {
        _db.Set<T>().Remove(entity);
    }
}