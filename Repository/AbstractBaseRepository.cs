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
        public abstract void CreateComplex(AbsEntity entity, AbsEntity entityKey);
        public abstract void Update(AbsEntity entity, int key);
        public abstract void UpdateComplex(AbsEntity entity, int key, AbsEntity entity2, int key2);
        public abstract void Delete(AbsEntity entity, int key);
        public abstract AbsEntity Load(AbsEntity entity, int key);
        public abstract List<AbsEntity> GetAll(AbsEntity entity);
        public abstract List<AbsEntity> Search(AbsEntity entity, string criteria);
    }
}
