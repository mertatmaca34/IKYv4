using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public interface IBaseRepository<TEntity>
{
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    TEntity Get(Expression<Func<TEntity, bool>> predicate);
    List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null);
}
