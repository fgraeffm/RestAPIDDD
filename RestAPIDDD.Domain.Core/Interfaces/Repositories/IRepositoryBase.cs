using System.Collections.Generic;

namespace RestAPIDDD.Domain.Core.Interfaces.Repositories {
    /// <summary>
    /// Interface base do repositório com os métodos de CRUD
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepositoryBase<TEntity> where TEntity : class {

        void Add(TEntity obj);

        void Update(TEntity obj);

        void Remove(TEntity obj);

        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);
    }
}