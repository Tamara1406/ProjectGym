using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CoachRepository : AbstractBaseRepository
    {
        public override void AddAll(List<AbsEntity> entities, AbsEntity entity)
        {
            throw new NotImplementedException();
        }

        public override void Create(AbsEntity entity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(AbsEntity entity, int key)
        {
            throw new NotImplementedException();
        }

        public override List<AbsEntity> GetAll(AbsEntity entity)
        {
            throw new NotImplementedException();
        }

        public override AbsEntity Load(AbsEntity entity, int key)
        {
            throw new NotImplementedException();
        }

        public override void Save(AbsEntity entity, int key)
        {
            throw new NotImplementedException();
        }

        public override List<AbsEntity> Search(AbsEntity entity, string criteria)
        {
            throw new NotImplementedException();
        }
    }
}
