﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Planstreet.ApplicationCore.Interfaces.Repository;
using Planstreet.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Planstreet.Infrastructure.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly PlanstreetContext Db;
        protected readonly DbSet<TEntity> DbSet;
        protected IDbContextTransaction _contextTransaction;

        protected BaseRepository(PlanstreetContext dbContext)
        {
            Db = dbContext;
            DbSet = Db.Set<TEntity>();
        }
        public virtual TEntity Add(TEntity entity)
        {
            DbSet.Add(entity);
            Db.SaveChanges();
            return entity;
        }
        public virtual void Update(TEntity entity)
        {
            DbSet.Update(entity);
            Db.SaveChanges();
        }
        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicado)
        {
            return DbSet.AsNoTracking().Where(predicado).ToList();
        }
        public virtual TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.AsNoTracking().ToList();
        }
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }
        public virtual void Remove(TEntity entity)
        {
            Db.Set<TEntity>().Remove(entity);
            Db.SaveChanges();
        }
        public virtual void BeginTransaction()
        {
            _contextTransaction = Db.Database.BeginTransaction();
        }
        public virtual void Commit()
        {
            _contextTransaction.Commit();
        }
        public virtual void Rollback()
        {
            _contextTransaction.Rollback();
        }
        public virtual void Detached(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Detached;
        }
    }
}
