using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Linq;

namespace InventoryManagement
{
    public class Repository<T> where T : Entity<int>
    {
        public Repository()
        {
            var context = new LightSpeedContext<LightSpeedModel1UnitOfWork>();
            context.ConnectionString = @"server=.\sqlexpress;database=Orders;Trusted_Connection=True;";
            context.IdentityMethod = IdentityMethod.IdentityColumn;

            _unitOfWork = context.CreateUnitOfWork();
        }
        private readonly IUnitOfWork _unitOfWork;

        public IList<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _unitOfWork.Query<T>().Where(predicate).ToList();
        }

        public IList<T> GetAll()
        {
            return _unitOfWork.Find<T>();
        }

        public void Add(T entity)
        {
            _unitOfWork.Add(entity);
        }

        public void DeleteAll()
        {
            foreach (var entity in GetAll())
            {
                Delete(entity);
            }
        }

        public void Delete(T entity)
        {
            _unitOfWork.Remove(entity);
        }

        public T FindById(int id)
        {
            return _unitOfWork.FindById<T>(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
