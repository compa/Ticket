using System.Linq.Expressions;

namespace TicketRepository;

public interface IRepositoryEntity<T>
{
    T Create(T entity);
    T GetById(int id);
    List<T> List();
    List<T> ListByCondition(Expression<Func<T, bool>> predicate);
    void Update(T entity);
    void Delete(T entity); 
}

