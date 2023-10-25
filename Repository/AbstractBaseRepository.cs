using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public abstract class AbstractBaseRepository
    {
        public abstract void Create(AbsEntity entity);
        public abstract void AddAll(List<AbsEntity> entities, AbsEntity entity);
        public abstract void Save(AbsEntity entity, int key);
        public abstract void Delete(AbsEntity entity, int key);
        public abstract AbsEntity Load(AbsEntity entity, int key);
        public abstract List<AbsEntity> GetAll(AbsEntity entity);
        public abstract List<AbsEntity> Search(AbsEntity entity, string criteria);
    }
}
