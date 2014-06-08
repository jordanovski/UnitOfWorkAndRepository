﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public sealed class RepositoryQuery<TEntity> where TEntity : class
    {
        private readonly List<Expression<Func<TEntity, object>>> includeProperties;

        private readonly Repository<TEntity> repository;
        private Expression<Func<TEntity, bool>> filter;
        private Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderByQuerable;
        private int? page;
        private int? pageSize;

        public RepositoryQuery(Repository<TEntity> repository)
        {
            this.repository = repository;
            includeProperties = new List<Expression<Func<TEntity, object>>>();
        }

        public RepositoryQuery<TEntity> Filter(Expression<Func<TEntity, bool>> filter)
        {
            this.filter = filter;
            return this;
        }

        public RepositoryQuery<TEntity> OrderBy(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
        {
            orderByQuerable = orderBy;
            return this;
        }

        public RepositoryQuery<TEntity> Include(Expression<Func<TEntity, object>> expression)
        {
            includeProperties.Add(expression);
            return this;
        }

        public IEnumerable<TEntity> GetPage(int page, int pageSize, out int totalCount)
        {
            this.page = page;
            this.pageSize = pageSize;
            totalCount = repository.Get(filter).Count();

            return repository.Get(filter, orderByQuerable, includeProperties, page, pageSize);
        }

        public IEnumerable<TEntity> Get()
        {
            return repository.Get(filter, orderByQuerable, includeProperties, page, pageSize);
        }
    }
}
